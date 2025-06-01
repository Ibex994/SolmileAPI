namespace SolmileGuesthouseAPI.Data.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public double BasicSalary { get; set; }
        public double Allowances { get; set; }
        public double Deductions { get; set; }
        public double NetSalary { get; set; }
        public DateTime PayPeriod { get; set; }
        public virtual Employee Employee { get; set; }
        public string DeductionReason { get; set; }
    }
}
