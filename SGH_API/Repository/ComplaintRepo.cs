using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class ComplaintRepo : ComplaintInterface
    {
        private readonly GuesthouseDbContext _context;

        public ComplaintRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AssignComplaintHandlerAsync(int employeeId, int complaintId)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            var employee = await _context.Employees.FindAsync(employeeId);
            if (complaint == null || employee == null) return false;

            complaint.EmployeeId = employeeId;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Complaint> CreateComplaintAsync(Complaint complaint)
        {
            if (complaint == null)
                return null;

            _context.Complaints.Add(complaint);
            await _context.SaveChangesAsync();

            return complaint;
        }
        public async Task<bool> DeleteComplaintAsync(int complaintId)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            if (complaint == null) return false;
            _context.Complaints.Remove(complaint);
            await _context.SaveChangesAsync();

            return true;
        }

        public bool EmployeeExist(int userid)
        {
            return _context.Employees.Any(e => e.Id == userid);
        }

        public async Task<Complaint> GetComplaintDetailsAsync(int complaintId)
        {
            return await _context.Complaints.Include(c => c.Customer).Include(c => c.Employee).FirstOrDefaultAsync(c => c.ComplaintId == complaintId);
        }

        public async Task<List<Complaint>> GetComplaintHistoryAsync(int customerId)
        {
            return await _context.Complaints
           .Where(c => c.CustomerId == customerId)
           .ToListAsync();
        }

        public async Task<bool> ResolveComplaintAsync(int complaintId)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            if (complaint == null)
                return false;

            complaint.Status = "Resolved";

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<string> TrackComplaintStatusAsync(int complaintId)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            return complaint?.Status ?? "Not Found";
        }

        public async Task<bool> UpdateComplaintStatusAsync(int complaintId, string status)
        {
            var complaint = await _context.Complaints.FindAsync(complaintId);
            if (complaint == null) return false;

            complaint.Status = status; 
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Complaint>> ViewComplaintsAsync()
        {
            return await _context.Complaints.ToListAsync();
        }
        public async Task<bool> CustomerExists(int customerId)
        {
            return await _context.Customers.AnyAsync(c => c.CustomerId == customerId);
        }
        public async Task<bool> EmployeeExists(int employeeId)
        {
            return await _context.Employees.AnyAsync(e => e.Id == employeeId);
        }
    }
}
