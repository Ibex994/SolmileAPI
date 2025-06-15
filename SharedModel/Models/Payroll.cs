namespace SolmileGuesthouseAPI.Data.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }

        public decimal BasicSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Tax { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime PayPeriod { get; set; }
        public virtual Employee Employee { get; set; }
        public string DeductionReason { get; set; }
    }
}
