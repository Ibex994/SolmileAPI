using System.ComponentModel.DataAnnotations;
using Solmile.Models;

namespace SolmileAPI.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }
        public string? Reason { get; set; }

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
