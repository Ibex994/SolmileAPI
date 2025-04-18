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
    }
}
