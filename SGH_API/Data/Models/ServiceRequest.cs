using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class ServiceRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }

        [Required]
        public string RequestedBy { get; set; }

        //       [Required]
        //       public string RequestorId { get; set; }

        public string? ReservationId { get; set; } // Nullable if requestor can be an employee
        public int? EmployeeId { get; set; } // Nullable if requestor can be a customer
        [ForeignKey("ReservationId")]
        public Reservation? Reservation { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
        //

        [ForeignKey("ServiceType")]
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime RequiredByDateTime { get; set; }

        [Required]
        public string Status { get; set; }
        public string ExtraDetail { get; set; }
        public string? AttachPhotoUrl { get; set; }

        // Navigation properties
        public ICollection<Task> Tasks { get; set; }
        public Rating Rating { get; set; }
    }
}