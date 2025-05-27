using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RatingId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("ServiceRequest")]
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; }

        public float RatingValue { get; set; }

        [Required]
        public DateTime RatingDate { get; set; }

        [Required]
        public string GivenBy { get; set; }
    }
    public class YearlyRatingsSummary
    {
        [Key]
        public int SummaryId { get; set; }
        public int EmployeeId { get; set; }
        public int Year { get; set; }
        public float TotalRatingSum { get; set; }
        public int TotalVotes { get; set; }
        public float AverageRating { get; set; }
        public Employee Employee { get; set; }
    }
}