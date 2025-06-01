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
        Task<float> CalculateNetSalaryAsync(int payrollId);
        Task<byte[]> GeneratePayslipPdfAsync(int EmployeeId);
        Task<List<Payroll>> GetPayrollsByEmployeeIdAsync(int employeeId);
        Task AddDeductionAsync(int payrollId, float amount, string reason);
        Task<List<Payroll>> GetPayrollsByDateAsync(DateTime payPeriod);
        

    }
}
