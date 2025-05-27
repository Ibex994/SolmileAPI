using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class PaymentMethod
    {
        [Key]
        public int MethodId { get; set; } 
        public string MethodName { get; set; }
        public ICollection<Payment> Payments { get; set; }

        public PaymentMethod()
        {
            Payments = null; 
        }
    }
}
