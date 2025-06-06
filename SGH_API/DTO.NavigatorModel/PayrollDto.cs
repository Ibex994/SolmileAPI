namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class PayrollDto
    {
            public int PayrollId { get; set; }
            public int EmployeeId { get; set; }
            public float BasicSalary { get; set; }
            public float Allowances { get; set; }
            public float Deductions { get; set; }
            public string? DeductionReason { get; set; }
            public float NetSalary { get; set; }
        }

    public class PayrollCreateDto
    {
        public int EmployeeId { get; set; }
        public float BasicSalary { get; set; }
        public float Allowances { get; set; }
        public DateTime PayPeriod { get; set; } = DateTime.Now;
        public float Deductions { get; set; }
        public string? DeductionReason { get; set; }
    }

    public class PayrollResponseDto
    {
        public int PayrollId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public DateTime PayPeriod { get; set; } = DateTime.Now;
        public float BasicSalary { get; set; }
        public float Allowances { get; set; }
        public float Deductions { get; set; }
        public string? DeductionReason { get; set; }
        public decimal Tax { get; set; }
        public float NetSalary { get; set; }
    }

    public class DeductionRequestDto
    {
        public float Amount { get; set; }
        public DateTime PayPeriod { get; set; } = DateTime.Now;
        public string Reason { get; set; } = string.Empty;
    }
}
