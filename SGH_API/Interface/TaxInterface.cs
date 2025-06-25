using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using System.Threading.Tasks;

namespace SolmileGuesthouseAPI.Interface
{
    public interface TaxInterface
    {
        Task<TaxResultDto> CalculateTaxAsync(float salary);
        Task<string> ViewTaxDetailsAsync(int employeeId);
        Task<Tax> GetTaxByIdAsync(int taxId);
        Task<IEnumerable<Tax>> GetTaxesByEmployeeIdAsync(int employeeId);
        Task<IEnumerable<Tax>> GetAllTaxesAsync();
        Task<Tax> CreateTaxAsync(Tax tax);
        Task<Tax> UpdateTaxAsync(int taxId, Tax updatedTax);
        Task<bool> DeleteTaxAsync(int taxId);

    }
}
