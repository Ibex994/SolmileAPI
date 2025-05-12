using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolmileAPI.Repository
{
    public class ReservationRepo : ReservationInterface
    {
        private readonly DataContext _context;
        private readonly ILogger<ReservationRepo> _logger;

        public ReservationRepo(DataContext context, ILogger<ReservationRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<(bool Success, string Message, Reservation? Created)> CreateReservationAsync(
     string roomId, DateTime checkIn, DateTime checkOut, int customerId)
        {
            if (!await _context.Room.AnyAsync(r => r.RoomID == roomId))
                return (false, $"Room with ID {roomId} does not exist.", null);

            if (!await _context.Customers.AnyAsync(c => c.CustomerId == customerId))
                return (false, $"Customer with ID {customerId} does not exist.", null);

            if (checkIn >= checkOut)
                return (false, "Check-out date must be after check-in date.", null);

            try
            {
                var reservation = new Reservation
                {
                    RoomId = roomId,
                    CustomerId = customerId,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    Status = "Pending"
                };

                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();

                return (true, "Reservation created.", reservation);
            }
            catch (Exception ex)
            {
                return (false, "Error occurred while creating reservation: " + ex.Message, null);
            }
        }




        public async Task<bool> CheckIfRoomExistsAsync(string roomId)
        {
            return await _context.Room.AnyAsync(r => r.RoomID == roomId);
        }

        public async Task<bool> UpdateReservationAsync(string reservationId, Reservation updatedDetails)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.CheckInDate = updatedDetails.CheckInDate;
            reservation.CheckOutDate = updatedDetails.CheckOutDate;
            reservation.RoomId = updatedDetails.RoomId;

            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateReservationAsync(string reservationId, DateTime newCheckOutDate)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.CheckOutDate = newCheckOutDate;
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CancelReservationAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.Status = "Cancelled"; 
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ConfirmReservationAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.Status = "Confirmed"; 
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExtendReservationAsync(string reservationId, DateTime newCheckOutDate)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.CheckOutDate = newCheckOutDate;
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Reservation> GetReservationDetailsAsync(string reservationId)
        {
            return await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);
        }

        public async Task<List<Reservation>> GetActiveReservationsAsync(int branchId)
        {
            return await _context.Reservations
                .Where(r => r.Status == "Pending" && r.Room.Branch.BranchId == branchId)
                .ToListAsync();
        }

        public async Task<bool> CheckInAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.Status = "Checked In"; 
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> CheckOutAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            reservation.Status = "Checked Out"; 
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Reservation>> ViewReservationHistoryAsync(int customerId)
        {
            return await _context.Reservations
                .Where(r => r.CustomerId == customerId)
                .OrderByDescending(r => r.CheckInDate)
                .ToListAsync();
        }
        public async Task<bool> DeleteReservationAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return false;

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<decimal> CalculatePaymentAsync(string reservationId)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Room) 
                .FirstOrDefaultAsync(r => r.ReservationId.ToString() == reservationId);

            if (reservation == null)
                return 0; 

           
            var roomType = reservation.Room.RoomType; 
            var pricePerNight = await _context.RoomTypes
                .Where(rt => rt.RoomTypeId == roomType)
                .Select(rt => rt.PricePerNight)
                .FirstOrDefaultAsync();

            if (pricePerNight == 0)
                return 0; 

            var numberOfNights = (reservation.CheckOutDate - reservation.CheckInDate).Days;
            var totalPayment = pricePerNight * numberOfNights;

            return totalPayment; 
        }



    }
}
