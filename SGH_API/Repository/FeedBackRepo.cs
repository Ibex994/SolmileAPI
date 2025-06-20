using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class FeedBackRepo : FeedBackInterface
    {
        private readonly GuesthouseDbContext _context;

        public FeedBackRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FeedBack>> GetAllFeedbacksAsync()
        {
            return await _context.Feedback.ToListAsync();
        }

        public async Task<(bool, string)> CreateFeedbackAsync(FeedBack feedback)
        {
            try
            {
                var reservationExists = await _context.Reservations
                    .AnyAsync(r => r.ReservationId == feedback.ReservationId);

                if (!reservationExists)
                    return (false, $"Reservation with ID {feedback.ReservationId} does not exist.");

                var customerExists = await _context.Customers
                    .AnyAsync(c => c.CustomerId == feedback.CustomerId);

                if (!customerExists)
                    return (false, $"Customer with ID {feedback.CustomerId} does not exist.");

                await _context.Feedback.AddAsync(feedback);
                await _context.SaveChangesAsync();

                return (true, "Feedback created successfully.");
            }
            catch (Exception ex)
            {
                return (false, "An error occurred while creating feedback.");
            }
        }


        public async Task<List<FeedBack>> GetFeedbacksByCustomerIdAsync(int customerId)
        {
            return await _context.Feedback
                .Where(f => f.CustomerId == customerId)
                .ToListAsync();
        }
        public async Task<FeedBack?> GetFeedbackByIdAsync(int feedbackId)
        {
            return await _context.Feedback
                .FirstOrDefaultAsync(f => f.FeedbackId == feedbackId);
        }

        public async Task<bool> UpdateFeedbackAsync(FeedBack feedback)
        {
            try
            {
                _context.Feedback.Update(feedback);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteFeedbackAsync(int feedbackId)
        {
            try
            {
                var feedback = await _context.Feedback.FindAsync(feedbackId);
                if (feedback == null)
                    return false;

                _context.Feedback.Remove(feedback);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}