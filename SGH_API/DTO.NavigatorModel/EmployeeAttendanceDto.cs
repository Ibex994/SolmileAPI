using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class AttendanceCreateDto
    {
        [Required]
        public DateTime AttendanceDate { get; set; }

        [Required]
        [MinLength(1)]
        public List<EmployeeAttendanceCreateDto> EmployeeAttendances { get; set; }
    }

    public class EmployeeAttendanceCreateDto
    {
        public int EmployeeId { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; }

        public bool IsPresent { get; set; }

        [StringLength(500)]
        public string? Reason { get; set; }
    }

    public class UpdateEmployeeAttendanceDto
    {
        public int EmployeeId { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }
        [StringLength(500)]
        public string? Reason { get; set; }
    }
    public class DailyAttendCreateDto
    {
        [Required]
        public DateTime AttendanceDate { get; set; }
    }
    public class MonthlyAttendanceSummaryDto
    {
        public int EmployeeId { get; set; }
        public string YearMonth { get; set; } = string.Empty;
        public int TotalDaysPresent { get; set; }
        public string? EmployeeFullName { get; set; }
    }
}
