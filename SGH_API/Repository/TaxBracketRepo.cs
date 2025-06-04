using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class TaxBracketRepo : TaxBracketInterface
    {
        private readonly GuesthouseDbContext _context;

        public TaxBracketRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<TaxBracket> CreateTaxBracketAsync(TaxBracket bracket)
        {
            _context.TaxBrackets.Add(bracket);
            await _context.SaveChangesAsync();
            return bracket;
        }
        public async Task<IEnumerable<TaxBracket>> GetAllTaxBracketsAsync()
        {
            return await _context.TaxBrackets
                .OrderBy(b => b.From)
                .ToListAsync();
        }
        public async Task<TaxBracket> GetTaxBracketByIdAsync(int id)
        {
            return await _context.TaxBrackets.FindAsync(id);
        }
    }
}
