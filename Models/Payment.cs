using System.ComponentModel.DataAnnotations;
using Solmile.Models;

namespace SolmileAPI.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } // Unique Payment ID

        public int ReservationId { get; set; } // The ID of the booking associated with this payment (FK)

        public float Amount { get; set; } // Payment amount

        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; } // Date the payment was made

        public int MethodId { get; set; } // The ID of the payment method (FK)

        // Navigation properties for relationships (if necessary)
        public virtual Reservation Reservation { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; } // Navigation to the related payment method
    }
}
