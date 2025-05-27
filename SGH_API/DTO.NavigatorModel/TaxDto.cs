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

}
