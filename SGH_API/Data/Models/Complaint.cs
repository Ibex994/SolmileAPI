namespace SolmileGuesthouseAPI.Data.Models
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
