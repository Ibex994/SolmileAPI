using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuesthouseAPI.Interface
{
    public interface TaxBracketInterface
    {
        Task<TaxBracket> CreateTaxBracketAsync(TaxBracket bracket);
        Task<TaxBracket> GetTaxBracketByIdAsync(int id);
        Task<IEnumerable<TaxBracketDto>> GetAllTaxBracketsAsync();

    }
}
