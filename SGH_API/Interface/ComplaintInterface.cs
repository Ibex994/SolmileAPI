using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface ComplaintInterface
    {
        Task<bool> UpdateComplaintStatusAsync(int complaintId, string status);
        Task<bool> ResolveComplaintAsync(int complaintId);
        Task<Complaint> GetComplaintDetailsAsync(int complaintId);
        Task<bool> AssignComplaintHandlerAsync(int employeeId, int complaintId);
        Task<string> TrackComplaintStatusAsync(int complaintId);
        Task<List<Complaint>> ViewComplaintsAsync();
        Task<List<Complaint>> GetComplaintHistoryAsync(int customerId);
        Task<Complaint> CreateComplaintAsync(Complaint complaint);
        Task<bool> DeleteComplaintAsync(int complaintId);
        Task<bool> CustomerExists(int customerId);
        Task<bool> EmployeeExists(int employeeId);
        bool EmployeeExist(int userid);

    }
}
