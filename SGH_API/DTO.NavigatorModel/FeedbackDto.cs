namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class FeedbackDto
    {
        public int FeedbackId { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateFeedbackDto
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
    }
}
