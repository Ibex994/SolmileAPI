using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface TaxBracketInterface
    {
        Task<TaxBracket> CreateTaxBracketAsync(TaxBracket bracket);
        Task<TaxBracket> GetTaxBracketByIdAsync(int id);
        Task<IEnumerable<TaxBracket>> GetAllTaxBracketsAsync();

    }
}
