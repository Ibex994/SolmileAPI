using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Enum;
using SolmileGuesthouseAPI.Interface;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Supervisor,Manager,HR")]
    public class AttendanceController : ControllerBase
    {
        private readonly AttendanceInterface _attendanceInterface;
        private readonly IMapper _mapper;
        private readonly ILogger<AttendanceController> _logger;
        private readonly MonthlyAttendanceSummaryInterface _monthlyAttendanceSummaryInterface;

        public AttendanceController(
            AttendanceInterface attendanceInterface,
            IMapper mapper,
            ILogger<AttendanceController> logger,
            MonthlyAttendanceSummaryInterface monthlyAttendanceSummaryInterface)
        {
            _attendanceInterface = attendanceInterface;
            _mapper = mapper;
            _logger = logger;
            _monthlyAttendanceSummaryInterface = monthlyAttendanceSummaryInterface;
        }

        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EmployeeAttendanceCreateDto>>> GetAll()
        {
            try
            {
                var data = await _attendanceInterface.GetAllAsync();
                if (data == null || !data.Any())
                {
                    return NotFound("No attendance records found.");
                }

                return Ok(_mapper.Map<List<EmployeeAttendanceCreateDto>>(data));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all attendance records");
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving attendance records.");
            }
        }

        [HttpGet("employee/{employeeId}/date/{date}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmployeeAttendanceCreateDto>> GetByEmployeeAndDate(
            [Range(1, int.MaxValue)] int employeeId,
            DateTime date)
        {
            try
            {
                var result = await _attendanceInterface.GetByEmployeeIdAndDateAsync(employeeId, date);
                if (result == null)
                {
                    _logger.LogInformation("Attendance not found for employee {EmployeeId} on {Date}", employeeId, date);
                    return NotFound("Attendance not found.");
                }

                return Ok(_mapper.Map<EmployeeAttendanceCreateDto>(result));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving attendance for employee {EmployeeId} on {Date}", employeeId, date);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving attendance record.");
            }
        }

        [HttpGet("employee/{employeeId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EmployeeAttendanceCreateDto>>> GetByEmployeeId(
            [Range(1, int.MaxValue)] int employeeId)
        {
            try
            {
                var records = await _attendanceInterface.GetByEmployeeIdAsync(employeeId);
                if (records == null || !records.Any())
                {
                    _logger.LogInformation("No attendance records found for employee {EmployeeId}", employeeId);
                    return NotFound("No attendance records found for this employee.");
                }

                return Ok(_mapper.Map<List<EmployeeAttendanceCreateDto>>(records));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving attendance for employee {EmployeeId}", employeeId);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving attendance records.");
            }
        }

        [HttpGet("date/{attendanceDate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EmployeeAttendanceCreateDto>>> GetAttendanceByDate(DateTime attendanceDate)
        {
            try
            {
                var attendances = await _attendanceInterface.GetAttendanceByDateAsync(attendanceDate);
                if (attendances == null || !attendances.Any())
                {
                    _logger.LogInformation("No attendance records found for date {Date}", attendanceDate);
                    return NotFound("No attendance records found for this date.");
                }

                return Ok(_mapper.Map<List<EmployeeAttendanceCreateDto>>(attendances));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving attendance for date {Date}", attendanceDate);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving attendance records.");
            }
        }

        [HttpPost("DailyEmployee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<IActionResult> CreateDailyAttendance([FromBody] AttendanceCreateDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogWarning("Invalid model state for attendance creation");
                    return BadRequest(ModelState);
                }

                var attendanceList = _mapper.Map<List<EmployeeAttendance>>(dto.EmployeeAttendances);
                var created = await _attendanceInterface.CreateDailyEmployeeAttendanceAsync(dto.AttendanceDate, attendanceList);

                if (!created)
                {
                    _logger.LogWarning("Attendance already exists for date {Date}", dto.AttendanceDate);
                    return Conflict(new { message = "Attendance for this date already exists." });
                }

                _logger.LogInformation("Attendance created successfully for date {Date}", dto.AttendanceDate);
                return CreatedAtAction(nameof(GetAttendanceByDate),
                    new { attendanceDate = dto.AttendanceDate },
                    new { message = "Attendance created successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating attendance for date {Date}", dto?.AttendanceDate);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating attendance records.");
            }
        }
        [HttpPost("DailyAttendance")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateDailyEmployeeAttendance([FromBody] DailyAttendCreateDto dto)
        {
            if (dto == null)
            {
                _logger.LogWarning("Received null DTO.");
                return BadRequest(new { message = "Invalid request. Attendance data is missing." });
            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid input received for daily attendance.");
                return BadRequest(new
                {
                    message = "There was a problem with your input. Please make sure the date is provided correctly.",
                    details = ModelState.Values
                                .SelectMany(v => v.Errors)
                                .Select(e => e.ErrorMessage)
                                .ToList()
                });
            }

            if (dto.AttendanceDate == default || dto.AttendanceDate.Date < DateTime.Today)
            {
                return BadRequest(new { message = "Attendance date must be today or a future date." });
            }

            try
            {
                var created = await _attendanceInterface.CreateDailyAttendanceAsync(dto.AttendanceDate);

                if (!created)
                {
                    _logger.LogWarning("Attendance already exists for {Date}", dto.AttendanceDate);
                    return Conflict(new
                    {
                        message = $"Attendance has already been submitted for {dto.AttendanceDate:MMMM-dd-yyyy}. You cannot submit it again."
                    });
                }

                _logger.LogInformation("Attendance successfully created for {Date}", dto.AttendanceDate);
                return CreatedAtAction(nameof(GetAttendanceByDate),
                    new { attendanceDate = dto.AttendanceDate },
                    new { message = $"Attendance for {dto.AttendanceDate:MMMM-dd-yyyy} has been successfully recorded." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "System error while recording attendance for {Date}", dto?.AttendanceDate);
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = "Sorry, something went wrong while saving the attendance. Please try again later or contact support."
                });
            }
        }

        [HttpPut("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateEmployeeAttendance([FromBody] UpdateEmployeeAttendanceDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _logger.LogWarning("Invalid model state for attendance update");
                    return BadRequest(ModelState);
                }

                var entity = _mapper.Map<EmployeeAttendance>(dto);
                var (response, updated) = await _attendanceInterface.UpdateEmployeeAttendanceAsync(entity);

                return response switch
                {
                    AttendanceResponse.Success => Ok(_mapper.Map<UpdateEmployeeAttendanceDto>(updated)),
                    AttendanceResponse.NotFound => NotFound("Attendance not found."),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating attendance record.")
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating attendance for employee {EmployeeId}", dto?.EmployeeId);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating attendance record.");
            }
        }

        [HttpDelete("employee/{employeeId}/date/{attendanceDate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAttendance(
            [Range(1, int.MaxValue)] int employeeId,
            DateTime attendanceDate)
        {
            try
            {
                var result = await _attendanceInterface.DeleteAttendanceAsync(employeeId, attendanceDate);

                if (!result)
                {
                    _logger.LogInformation("Attendance not found for employee {EmployeeId} on {Date}", employeeId, attendanceDate);
                    return NotFound("Attendance record not found for this employee and date.");
                }

                _logger.LogInformation("Attendance deleted for employee {EmployeeId} on {Date}", employeeId, attendanceDate);
                return Ok("Attendance record deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting attendance for employee {EmployeeId} on {Date}", employeeId, attendanceDate);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting attendance record.");
            }
        }

        [HttpGet("all-dates")]
        public async Task<IActionResult> GetAllAttendanceDates()
        {
            try
            {
                var dates = await _attendanceInterface.GetAllAttendanceDatesAsync();
                if (dates == null || !dates.Any())
                    return NotFound("No attendance dates found.");

                return Ok(dates.Select(d => new DailyAttendCreateDto { AttendanceDate = d }));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting attendance dates.");
                return StatusCode(500, "Error loading attendance dates.");
            }
        }

        [HttpGet("monthly-summary")]
        public async Task<IActionResult> GetAll([FromQuery] string yearMonth)
        {
            var result = await _monthlyAttendanceSummaryInterface.GetMonthlySummariesAsync(yearMonth);
            return Ok(result);
        }

        [HttpGet("monthly-summary/employee/{employeeId}/year-month/{yearMonth}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMonthlySummaryByEmployeeId(int employeeId, string yearMonth)
        {
            try
            {
                var summary = await _monthlyAttendanceSummaryInterface.GetMonthlySummaryByEmployeeIdAsync(employeeId, yearMonth);
                if (summary == null)
                {
                    _logger.LogInformation("No monthly summary found for EmployeeId {EmployeeId} in {YearMonth}", employeeId, yearMonth);
                    return NotFound($"No monthly summary found for EmployeeId {employeeId} in {yearMonth}.");
                }
                return Ok(summary);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving monthly summary for EmployeeId {EmployeeId} in {YearMonth}", employeeId, yearMonth);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving monthly summary.");
            }
        }
    }
}