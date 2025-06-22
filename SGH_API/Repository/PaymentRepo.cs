using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuesthouseAPI.Repository
{
    public class PaymentRepo : PaymentInterface
    {
        private readonly GuesthouseDbContext _context;

        public PaymentRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            _context.payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
        {
            return await _context.payments.ToListAsync();
        }

        public async Task<Payment> GetPaymentByIdAsync(int paymentId)
        {
            return await _context.payments.FindAsync(paymentId);
        }

        public async Task<Payment> UpdatePaymentAsync(int paymentId, Payment updatedPayment)
        {
            var payment = await _context.payments.FindAsync(paymentId);
            if (payment == null) return null;

            payment.Amount = updatedPayment.Amount;
            payment.MethodId = updatedPayment.MethodId;

            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<bool> DeletePaymentAsync(int paymentId)
        {
            var payment = await _context.payments.FindAsync(paymentId);
            if (payment == null) return false;

            _context.payments.Remove(payment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<PaymentResultDto> ProcessPaymentAsync(string reservationId, int methodId)
        {
            if (string.IsNullOrWhiteSpace(reservationId) || methodId <= 0)
            {
                return new PaymentResultDto
                {
                    Success = false,
                    Message = "Invalid input parameters."
                };
            }

            var reservation = await _context.Reservations.FindAsync(reservationId);
            if (reservation == null)
            {
                return new PaymentResultDto
                {
                    Success = false,
                    Message = "Reservation not found."
                };
            }

            if (reservation.Status == "Paid" || reservation.Status == "Cancelled")
            {
                return new PaymentResultDto
                {
                    Success = false,
                    Message = $"Cannot process payment. Reservation is already {reservation.Status}."
                };
            }

            bool paymentSuccess = true;

            if (!paymentSuccess)
            {
                return new PaymentResultDto
                {
                    Success = false,
                    Message = "Payment processing failed via gateway."
                };
            }

            var payment = new Payment
            {
                ReservationId = reservationId,
                Amount = reservation.TotalPrice,
                MethodId = methodId,
                PaymentDate = DateTime.UtcNow
            };

            _context.payments.Add(payment);

            reservation.Status = "Confirmed";

            await _context.SaveChangesAsync();

            return new PaymentResultDto
            {
                Success = true,
                Message = "Payment processed successfully.",
                AmountPaid = reservation.TotalPrice,
                PaymentDate = payment.PaymentDate
            };
        }

        public async Task<IEnumerable<Payment>> GetPaymentsByReservationIdAsync(string reservationId)
        {
            return await _context.payments
                .Where(p => p.ReservationId == reservationId)
                .Include(p => p.PaymentMethod)  // Include related data if needed
                .Include(p => p.Reservation)   // Include related data if needed
                .ToListAsync();
        }
    }
}
