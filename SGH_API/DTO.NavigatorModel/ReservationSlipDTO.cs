namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class ReservationSlipDTO
    {
        public string FullName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public float AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string ReservationCode { get; set; }
    }

}
