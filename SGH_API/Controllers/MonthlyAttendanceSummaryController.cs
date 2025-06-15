using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonthlyAttendanceSummaryController : ControllerBase
    {
        private readonly MonthlyAttendanceSummaryInterface _monthlyAttendanceSummaryInterface;

        public MonthlyAttendanceSummaryController(MonthlyAttendanceSummaryInterface monthlyAttendanceSummaryInterface)
        {
            _monthlyAttendanceSummaryInterface = monthlyAttendanceSummaryInterface;
        }
        [HttpGet("YearMonth")]
        public async Task<IActionResult> GetAll([FromQuery] string yearMonth)
        {
            var result = await _monthlyAttendanceSummaryInterface.GetMonthlySummariesAsync(yearMonth);
            return Ok(result);
        }

        [HttpGet("YearMonth/{employeeId}")]
        public async Task<IActionResult> GetById(int employeeId, [FromQuery] string yearMonth)
        {
            var summary = await _monthlyAttendanceSummaryInterface.GetMonthlySummaryByEmployeeIdAsync(employeeId, yearMonth);
            if (summary == null)
                return NotFound($"No summary found for EmployeeId {employeeId} in {yearMonth}.");

            return Ok(summary);
        }
    }
}
