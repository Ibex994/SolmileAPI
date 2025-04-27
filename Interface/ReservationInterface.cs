using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface ReservationInterface
    {
            Task<float> CalculatePaymentAsync(string reservationId);
            Task<Reservation> CreateReservationAsync( string roomId, DateTime checkIn, DateTime checkOut);
            Task<bool> UpdateReservationAsync(string reservationId, Reservation updatedDetails);
            Task<bool> UpdateReservationAsync(string reservationId, DateTime newCheckOutDate);
            Task<bool> CancelReservationAsync(string reservationId);
            Task<bool> ConfirmReservationAsync(string reservationId);
            Task<bool> ExtendReservationAsync(string reservationId, DateTime newCheckOutDate);
            Task<Reservation> GetReservationDetailsAsync(string reservationId);
            Task<List<Reservation>> GetActiveReservationsAsync(int branchId);
            Task<bool> CheckInAsync(string reservationId);
            Task<bool> CheckOutAsync(string reservationId);
            Task<List<Reservation>> ViewReservationHistoryAsync(int customerId);
            Task<bool> DeleteReservationAsync(string reservationId);
            public Task<bool> CheckIfRoomExistsAsync(string roomId);
            Task<bool> SaveAsync();
    }

 }