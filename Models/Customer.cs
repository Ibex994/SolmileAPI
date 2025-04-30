using Solmile.Models;
using System.ComponentModel.DataAnnotations;
namespace SolmileAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // Navigation Properties
        public ICollection<Complaint> Complaints { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<ServiceRequest> ServiceRequests { get; set; }
        public ICollection<FeedBack> Feedbacks { get; set; }
    }


}
