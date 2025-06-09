namespace SolmileGuesthouseAPI.Data.Models
{
    public class FeedBack
    {
        public int FeedbackId { get; set; }
        public string ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Reservation Reservation { get; set; }
        public Customer Customer { get; set; }
    }
}
