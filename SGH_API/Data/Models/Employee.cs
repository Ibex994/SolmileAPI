using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Employee : User
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public string Gender { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        // Navigation properties
        public ICollection<ServiceRequest> ServiceRequests { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Rating> RatingsReceived { get; set; }
    }
}