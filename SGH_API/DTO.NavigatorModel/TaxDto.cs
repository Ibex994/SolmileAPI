namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class TaxDto
    {
        public int TaxId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
    }
    public class CreateTaxDto
    {
        public int EmployeeId { get; set; }
        public decimal TaxRate { get; set; }
    }

    public class UpdateTaxDto
    {
        public int EmployeeId { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
    }

    public class CreateTaxBracketDto
    {
        public decimal From { get; set; }
        public decimal To { get; set; }
        public decimal RatePercent { get; set; }
        public decimal Deductible { get; set; }
    }

    public class TaxResultDto
    {
        public decimal GrossSalary { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetSalary { get; set; }
        public decimal TaxRateApplied { get; set; }
        public decimal Deductible { get; set; }
    }
    public class GrossSalaryDto
    {
        public decimal GrossSalary { get; set; }
    }

}
