namespace SolmileGuesthouseAPI.Data.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public float BasicSalary { get; set; }
        public float Allowances { get; set; }
        public string? DeductionReason { get; set; }
        public float Deductions { get; set; }
        public float NetSalary { get; set; }
        public DateTime PayPeriod { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
