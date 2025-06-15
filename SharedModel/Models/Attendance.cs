using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        [Required]
        public DateTime AttendanceDate { get; set; } 
        public ICollection<EmployeeAttendance> EmployeeAttendances { get; set; } = new List<EmployeeAttendance>();
    }
    public class EmployeeAttendance
    {
        [Key]
        public int EmployeeAttendanceId { get; set; }

        public int EmployeeId { get; set; }

        public int AttendanceId { get; set; }

        public DateTime AttendanceDate { get; set; }

        public bool IsPresent { get; set; }

        public string? EmployeeFullName { get; set; }

        public string? Reason { get; set; }

        [ForeignKey("AttendanceId")]
        public Attendance Attendance { get; set; } = null!;

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = null!;
    }

    public class MonthlyAttendanceSummary
    {
        [Key]
        public int SummaryId { get; set; }
        public int EmployeeId { get; set; }
        public string YearMonth { get; set; }
        public int TotalDaysPresent { get; set; }
        public string? EmployeeFullName { get; set; }
        public Employee Employee { get; set; }
    }
}
