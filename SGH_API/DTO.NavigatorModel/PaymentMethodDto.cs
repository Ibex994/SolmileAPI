using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class PaymentMethodDto
    {
        public int MethodId { get; set; }
        public string MethodName { get; set; }
    }
    public class CreatePaymentMethodDto
    {
        [Required]
        public string MethodName { get; set; }
    }    
    public class UpdatePaymentMethodDto
    {
        [Required]
        public string MethodName { get; set; }
    }
}  
