using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Log
    {
        [Key]
        public int LogId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Action { get; set; }

        public int? PerformedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public virtual Employee Performer { get; set; }
        public LogLevel Level { get; set; }
    }
}
