using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface LogInterface
    {
        Task<bool> CreateLogAsync(string action, LogLevel level, int? performedBy,string Fname, string Lname);
        Task<List<Log>> GetAllLogsAsync();
        Task<List<Log>> GetLogsByEmployeeAsync(int employeeId);
    }
}
