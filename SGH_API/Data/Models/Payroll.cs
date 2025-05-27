namespace SolmileGuesthouseAPI.Data.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public float BasicSalary { get; set; }
        public float Allowances { get; set; }
        public float Deductions { get; set; }
        private float NetSalary;

        public virtual Employee Employee { get; set; }

        // Method to calculate NetSalary
        private float CalculateNetSalary()
        {
            return BasicSalary + Allowances - Deductions;
        }
    }
}
