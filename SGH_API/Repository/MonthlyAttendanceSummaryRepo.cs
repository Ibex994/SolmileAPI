using System.Globalization;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuesthouseAPI.Repository
{
    public class MonthlyAttendanceSummaryRepo : MonthlyAttendanceSummaryInterface
    {
        private readonly GuesthouseDbContext _context;

        public MonthlyAttendanceSummaryRepo(GuesthouseDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<MonthlyAttendanceSummaryDto>> GetMonthlySummariesAsync(string yearMonth)
        {
            if (!DateTime.TryParseExact(yearMonth + "-01", "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
                return Enumerable.Empty<MonthlyAttendanceSummaryDto>();

            DateTime endDate = startDate.AddMonths(1);

            return await _context.EmployeeAttendances
                .Where(a => a.AttendanceDate >= startDate && a.AttendanceDate < endDate && a.IsPresent)
                .GroupBy(a => new { a.EmployeeId, a.Employee.FirstName, a.Employee.LastName })
                .Select(g => new MonthlyAttendanceSummaryDto
                {
                    EmployeeId = g.Key.EmployeeId,
                    YearMonth = yearMonth,
                    TotalDaysPresent = g.Count(),
                    EmployeeFullName = g.Key.FirstName + " " + g.Key.LastName
                })
                .ToListAsync();
        }

        public async Task<MonthlyAttendanceSummaryDto?> GetMonthlySummaryByEmployeeIdAsync(int employeeId, string yearMonth)
        {
            if (!DateTime.TryParseExact(yearMonth + "-01", "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
                return null;

            DateTime endDate = startDate.AddMonths(1);

            var query = await _context.EmployeeAttendances
                .Where(a => a.EmployeeId == employeeId && a.AttendanceDate >= startDate && a.AttendanceDate < endDate && a.IsPresent)
                .GroupBy(a => new { a.EmployeeId, a.Employee.FirstName, a.Employee.LastName })
                .Select(g => new MonthlyAttendanceSummaryDto
                {
                    EmployeeId = g.Key.EmployeeId,
                    YearMonth = yearMonth,
                    TotalDaysPresent = g.Count(),
                    EmployeeFullName = g.Key.FirstName + " " + g.Key.LastName
                })
                .FirstOrDefaultAsync();

            return query;
        }
    }
}

