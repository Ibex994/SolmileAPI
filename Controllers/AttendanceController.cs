using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolmileAPI.DTO;
using SolmileAPI.Enum;
using SolmileAPI.Interface;
using SolmileAPI.Models;
using SolmileAPI.Repository;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private readonly AttendanceInterface _attendanceInterface;
        private readonly IMapper _mapper;

        public AttendanceController(AttendanceInterface attendanceInterface, IMapper mapper) 
        {
            _attendanceInterface = attendanceInterface;
            _mapper = mapper;
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _attendanceInterface.GetAllAsync();
            var dto = _mapper.Map<List<EmployeeAttendanceDto>>(data);
            return Ok(dto);
        }

        [HttpGet("employee/{employeeId}/date/{date}")]
        public async Task<IActionResult> GetByEmployeeAndDate(int employeeId, DateTime date)
        {
            var result = await _attendanceInterface.GetByEmployeeIdAndDateAsync(employeeId, date);
            if (result == null) return NotFound("Attendance not found.");

            return Ok(_mapper.Map<EmployeeAttendanceDto>(result));
        }

        [HttpGet("employee/{employeeId}")]
        public async Task<IActionResult> GetByEmployeeId(int employeeId)
        {
            var records = await _attendanceInterface.GetByEmployeeIdAsync(employeeId);
            return Ok(_mapper.Map<List<EmployeeAttendanceDto>>(records));
        }

        [HttpGet("date/{attendanceDate}")]
        public async Task<IActionResult> GetAttendanceByDate(DateTime attendanceDate)
        {
            // Call the service method to get all attendance records for the given date
            var attendances = await _attendanceInterface.GetAttendanceByDateAsync(attendanceDate);

            if (attendances == null || !attendances.Any())
                return NotFound("No attendance records found for this date.");

            // Return the records mapped to the DTO
            return Ok(_mapper.Map<List<EmployeeAttendanceDto>>(attendances));
        }


        [HttpPost("create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateDailyAttendance([FromBody] AttendanceCreateDto dto)
        {
            var attendanceList = _mapper.Map<List<EmployeeAttendance>>(dto.EmployeeAttendances);
            var created = await _attendanceInterface.CreateDailyAttendanceAsync(dto.AttendanceDate, attendanceList);

            if (!created)
                return BadRequest(new { message = "Attendance for this date already exists." });

            return Ok(new { message = "Attendance created successfully." });
        }


        [HttpPut("update")]
        public async Task<IActionResult> UpdateEmployeeAttendance([FromBody] UpdateEmployeeAttendanceDto dto)
        {
            if (dto.EmployeeId == 0) return BadRequest("EmployeeId is required.");

            var entity = _mapper.Map<EmployeeAttendance>(dto);
            var (response, updated) = await _attendanceInterface.UpdateEmployeeAttendanceAsync(entity);

            return response switch
            {
                AttendanceResponse.Success => Ok(_mapper.Map<EmployeeAttendanceDto>(updated)),
                AttendanceResponse.NotFound => NotFound("Attendance not found."),
                _ => StatusCode(500, "An error occurred.")
            };
        }

        [HttpDelete("employee/{employeeId}/date/{attendanceDate}")]
        public async Task<IActionResult> DeleteAttendance(int employeeId, DateTime attendanceDate)
        {
            var result = await _attendanceInterface.DeleteAttendanceAsync(employeeId, attendanceDate);

            if (!result)
                return NotFound("Attendance record not found for this employee and date.");

            return Ok("Attendance record deleted successfully.");
        }

    }
}

