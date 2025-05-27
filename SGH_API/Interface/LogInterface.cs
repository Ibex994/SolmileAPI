using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface LogInterface
    {
        Task<bool> CreateLogAsync(string action, LogLevel level, int? performedBy);
        Task<List<Log>> GetAllLogsAsync();
        Task<List<Log>> GetLogsByEmployeeAsync(int employeeId);
    }
}
