using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuesthouseAPI.Interface
{
    public interface PaymentInterface
    {
        Task<Payment> CreatePaymentAsync(Payment payment);
        Task<IEnumerable<Payment>> GetAllPaymentsAsync();
        Task<Payment> GetPaymentByIdAsync(int paymentId);
        Task<Payment> UpdatePaymentAsync(int paymentId, Payment updatedPayment);
        Task<bool> DeletePaymentAsync(int paymentId);
        Task<PaymentResultDto> ProcessPaymentAsync(string reservationId, float amount, int methodId);
    }
}
