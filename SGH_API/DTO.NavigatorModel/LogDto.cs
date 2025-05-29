namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class LogDto
    {
        public int LogId { get; set; }
        public string Action { get; set; }
        public string Level { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PerformedBy { get; set; }
        public DateTime Timestamp { get; set; }
    }

   
}