namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class PaymentDto
    {
        public int PaymentID { get; set; }
        public string ReservationId { get; set; }
        public float Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int MethodId { get; set; }
    }

    public class CreatePaymentDto
    {
        public string ReservationId { get; set; }
        public float Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int MethodId { get; set; }
    }

    public class UpdatePaymentDto
    {
        public float Amount { get; set; }
        public int MethodId { get; set; }
    }

    public class ProcessPaymentDto
    {
        public string ReservationId { get; set; }
        public int MethodId { get; set; }
    }
    public class PaymentResultDto
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public float? AmountPaid { get; set; }
        public DateTime? PaymentDate { get; set; }
    }

}
