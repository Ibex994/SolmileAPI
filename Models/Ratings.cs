using System;
using System.ComponentModel.DataAnnotations;

namespace Solmile.Models
{
    public class Ratings
    {
        [Key]
        public int RatingId { get; set; }
        public int EmployeeId { get; set; }
        public float RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public string IsGivenBy { get; set; }
        public Employee Employee { get; set; }
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
