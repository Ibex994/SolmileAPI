using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Tax
    {
        public int TaxId { get; set; }
        public int EmployeeId { get; set; }
        [Precision(18, 2)]
        public decimal TaxAmount { get; set; }

        [Precision(5, 4)]
        public decimal TaxRate { get; set; }

        [Precision(18, 2)]
        public decimal Deduction { get; set; }

        public Employee Employee { get; set; }
    }
    public class TaxBracket
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Precision(18, 4)]
        public decimal From { get; set; }
        [Precision(18, 4)]
        public decimal To { get; set; }
        [Precision(7, 4)] 
        public decimal RatePercent { get; set; }
        [Precision(18, 2)]
        public decimal Deductible { get; set; }
    }

}
