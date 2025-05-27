using SolmileGuesthouseAPI.Data.Models;
using Task = System.Threading.Tasks.Task;
namespace SolmileGuesthouseAPI.Interface
{
    public interface PayrollInterface
    {
        Task<Payroll> GetPayrollByIdAsync(int payrollId);
        Task<List<Payroll>> GetAllPayrollsAsync();
        Task<Payroll> CreateOrUpdatePayrollAsync(Payroll payroll);
        Task<bool> DeletePayrollAsync(int payrollId);

        // Business Logic
        Task<float> CalculateNetSalaryAsync(int payrollId);
        Task<string> GeneratePayslipAsync(int payrollId);
        Task<List<Payroll>> GetPayrollsByEmployeeIdAsync(int employeeId);

        // Deduction-Specific
        Task AddDeductionAsync(int payrollId, float amount, string reason);
    }
}
