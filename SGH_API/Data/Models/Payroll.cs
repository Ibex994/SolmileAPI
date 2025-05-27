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
        public float NetSalary;

        public virtual Employee Employee { get; set; }
        private float CalculateNetSalary()
        {
            return BasicSalary + Allowances - Deductions;
        }
    }
}
