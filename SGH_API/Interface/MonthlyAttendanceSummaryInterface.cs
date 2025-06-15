using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuesthouseAPI.Interface
{
    public interface MonthlyAttendanceSummaryInterface
    {
        Task<IEnumerable<MonthlyAttendanceSummaryDto>> GetMonthlySummariesAsync(string yearMonth);
        Task<MonthlyAttendanceSummaryDto?> GetMonthlySummaryByEmployeeIdAsync(int employeeId, string yearMonth);
    }
}
