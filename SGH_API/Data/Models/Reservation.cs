using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Reservation
    {
        [Key]
        public string ReservationId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }
        public Room Room { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public float TotalPrice { get; set; }

        [Required]
        public string Status { get; set; }

        // Navigation property
        public ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual Payment Payment { get; set; }
        public ICollection<FeedBack> Feedbacks { get; set; }
    }
}