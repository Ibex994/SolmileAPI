using System.ComponentModel.DataAnnotations;

namespace SolmileAPI.Models
{
    public class PaymentMethod
    {
        [Key]
        public int MethodId { get; set; } // Unique ID for the Payment Method
        public string MethodName { get; set; } // Name of the Payment Method (e.g., Credit Card, PayPal)
        // Navigation property to Payment (One-to-one relationship)
        public Payment Payment { get; set; }
        public PaymentMethod()
        {
            Payment = null; // Payment can be null initially, since it's a one-to-one
        }
    }
}