using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface FeedBackInterface
    {
        Task<(bool, string)> CreateFeedbackAsync(FeedBack feedback);
        Task<List<FeedBack>> GetFeedbacksByCustomerIdAsync(int customerId);
        Task<FeedBack?> GetFeedbackByIdAsync(int feedbackId);
        Task<bool> UpdateFeedbackAsync(FeedBack feedback);
        Task<bool> DeleteFeedbackAsync(int feedbackId);
    }
}
