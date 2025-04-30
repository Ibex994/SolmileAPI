using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SolmileAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solmile.Models
{
    public class Employee : User
    {
        [Required]
        public string FirstName { get; set; } 
        [Required]
        public string LastName { get; set; } 
        [Required]
        public string Position { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; } 
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public string Gender { get; set; }
       

        // Navigation Property
        public virtual User User { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<EmployeeTask> EmployeeTasks { get; set; }
        public ICollection<Log> Logs { get; set; }
        public ICollection<Payroll> Payrolls { get; set; }
        public ICollection<Tax> Taxs { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
        public MonthlyAttendanceSummary MonthlyAttendanceSummary { get; set; }
        public ICollection<Ratings> Ratings { get; set; }
        public YearlyRatingsSummary YearlyRatingsSummary { get; set; }
    }
}
