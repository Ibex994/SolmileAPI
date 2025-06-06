using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } 
        public string ReservationId { get; set; } 
        public float Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; } 
        public int MethodId { get; set; } 
        public virtual Reservation Reservation { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; } 
    }
}
