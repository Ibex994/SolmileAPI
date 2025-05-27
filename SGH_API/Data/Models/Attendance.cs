using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; } = DateTime.UtcNow;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<EmployeeAttendance> EmployeeAttendances { get; set; } = new List<EmployeeAttendance>();
    }
    public class EmployeeAttendance
    {
        [Key]
        public int EmpAttendanceId { get; set; }
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AttendanceDate { get; set; } = DateTime.UtcNow;
        public bool IsPresent { get; set; }
        public string? Reason { get; set; }
        [Required]
        public int AttendanceId { get; set; }
        public Attendance Attendance { get; set; } = null!;
        public Employee Employee { get; set; }
    }

    public class MonthlyAttendanceSummary
    {
        [Key]
        public int SummaryId { get; set; }
        public int EmployeeId { get; set; }
        public string YearMonth { get; set; }
        public int TotalDaysPresent { get; set; }

        public Employee Employee { get; set; }
    }
}
