using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuesthouseAPI.Interface
{
    public interface MonthlyAttendanceSummaryInterface
    {
        Task GetMonthlySummariesAsync(string yearMonth);
        Task<List<MonthlyAttendanceSummaryDto>> GetMonthlySummariesDataAsync(string yearMonth);
        Task<MonthlyAttendanceSummaryDto?> GetMonthlySummaryByEmployeeIdAsync(int employeeId, string yearMonth);
    }
}
