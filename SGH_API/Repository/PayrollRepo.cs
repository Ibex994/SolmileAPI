    using Microsoft.EntityFrameworkCore;
    using SolmileGuesthouseAPI.Data;
    using SolmileGuesthouseAPI.Data.Models;
    using SolmileGuesthouseAPI.Interface;
    using Task = System.Threading.Tasks.Task;
namespace SolmileGuesthouseAPI.Repository
    {
        public class PayrollRepo : PayrollInterface
        {
            private readonly GuesthouseDbContext _context;

            public PayrollRepo(GuesthouseDbContext context)
            {
                _context = context;
            }
            // CRUD
            public async Task<Payroll> GetPayrollByIdAsync(int payrollId)
            {
                return await _context.Payroll
                    .Include(p => p.Employee)
                    .FirstOrDefaultAsync(p => p.PayrollId == payrollId)
                    .ConfigureAwait(false);
            }

            public async Task<List<Payroll>> GetAllPayrollsAsync()
            {
                return await _context.Payroll
                    .Include(p => p.Employee)
                    .ToListAsync()
                    .ConfigureAwait(false);
            }

            public async Task<Payroll> CreateOrUpdatePayrollAsync(Payroll payroll)
            {
                if (payroll.Deductions > 0 && string.IsNullOrWhiteSpace(payroll.DeductionReason))
                    throw new ArgumentException("Deduction reason is required when deductions exist");

                if (payroll.Deductions == 0)
                    payroll.DeductionReason = null;

                if (payroll.PayrollId == 0)
                    _context.Payroll.Add(payroll);
                else
                    _context.Payroll.Update(payroll);

                await _context.SaveChangesAsync().ConfigureAwait(false);
                return payroll;
            }

            public async Task<bool> DeletePayrollAsync(int payrollId)
            {
                var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
                if (payroll == null) return false;

                _context.Payroll.Remove(payroll);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                return true;
            }

            // Business Logic
            public async Task<float> CalculateNetSalaryAsync(int payrollId)
            {
                var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
                if (payroll == null) throw new Exception("Payroll not found");

                payroll.NetSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions;
                await _context.SaveChangesAsync().ConfigureAwait(false);
                return payroll.NetSalary;
            }

            public async Task<string> GeneratePayslipAsync(int payrollId)
            {
                var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
                if (payroll == null) throw new Exception("Payroll not found");

                return $"PAYSLIP - {DateTime.Now:yyyy-MM-dd}\n" +
                       $"Employee: {payroll.Employee.FirstName + payroll.Employee.LastName} (ID: {payroll.EmployeeId})\n" +
                       $"Basic Salary: {payroll.BasicSalary}\n" +
                       $"Allowances: {payroll.Allowances}\n" +
                       $"Deductions: {payroll.Deductions}\n" +
                       $"{(payroll.DeductionReason != null ? $"Deduction Reason: {payroll.DeductionReason}\n" : "")}" +
                       $"Net Salary: {payroll.NetSalary}";
            }

        public async Task<List<Payroll>> GetPayrollsByEmployeeIdAsync(int employeeId)
        {
            return await _context.Payroll
                .Where(p => p.EmployeeId == employeeId)
                .Include(p => p.Employee)
                .ToListAsync()
                .ConfigureAwait(false);
        }     

        public async Task AddDeductionAsync(int payrollId, float amount, string reason)
        {
            var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
            if (payroll == null) throw new Exception("Payroll not found");

            payroll.Deductions += amount;
            payroll.DeductionReason = reason;
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
    }