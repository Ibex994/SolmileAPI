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
        public async Task GetMonthlySummariesAsync(string yearMonth)
        {
            if (!DateTime.TryParseExact(yearMonth, "yyyy-MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedMonth))
                return;

            var startDate = new DateTime(parsedMonth.Year, parsedMonth.Month, 1);
            var endDate = startDate.AddMonths(1);

            var summaries = await _context.EmployeeAttendances
                .Include(a => a.Employee)
                .Where(a => a.AttendanceDate >= startDate && a.AttendanceDate < endDate && a.IsPresent)
                .GroupBy(a => new { a.EmployeeId })
                .Select(g => new MonthlyAttendanceSummary
                {
                    EmployeeId = g.Key.EmployeeId,
                    YearMonth = yearMonth,
                    TotalDaysPresent = g.Count(),
                    EmployeeFullName = g.Select(a => a.Employee != null ? a.Employee.Username : "Unknown").FirstOrDefault()
                })
                .ToListAsync();

            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var existing = _context.monthlyAttendanceSummaries.Where(s => s.YearMonth == yearMonth);
                _context.monthlyAttendanceSummaries.RemoveRange(existing);
                await _context.monthlyAttendanceSummaries.AddRangeAsync(summaries);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<MonthlyAttendanceSummaryDto?> GetMonthlySummaryByEmployeeIdAsync(int employeeId, string yearMonth)
        {
            if (!DateTime.TryParseExact(yearMonth, "yyyy-MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedMonth))
                return null;

            var startDate = new DateTime(parsedMonth.Year, parsedMonth.Month, 1);
            var endDate = startDate.AddMonths(1);


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
        public async Task<List<MonthlyAttendanceSummaryDto>> GetMonthlySummariesDataAsync(string yearMonth)
        {
            if (!DateTime.TryParseExact(yearMonth + "-01", "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var startDate))
                return new List<MonthlyAttendanceSummaryDto>(); // or throw exception if preferred

            var endDate = startDate.AddMonths(1);

            var summaries = await _context.monthlyAttendanceSummaries
                .Where(s => s.YearMonth == yearMonth)
                .Select(s => new MonthlyAttendanceSummaryDto
                {
                    EmployeeId = s.EmployeeId,
                    EmployeeFullName = s.EmployeeFullName,
                    YearMonth = s.YearMonth,
                    TotalDaysPresent = s.TotalDaysPresent
                })
                .ToListAsync();

            return summaries;
        }

    }
}

