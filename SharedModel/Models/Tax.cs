using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Tax
    {
        public int TaxId { get; set; }
        public int EmployeeId { get; set; }
        public decimal GrossSalary { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
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
