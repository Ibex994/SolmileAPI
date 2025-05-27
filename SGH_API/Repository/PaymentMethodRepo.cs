using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class PaymentMethodRepo : PaymentMethodInterface
    {
        private readonly GuesthouseDbContext _context;

        public PaymentMethodRepo(GuesthouseDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PaymentMethod>> GetAllAsync()
        {
            return await _context.paymentMethods.ToListAsync();
        }

        public async Task<PaymentMethod> GetByIdAsync(int id)
        {
            return await _context.paymentMethods.FindAsync(id);
        }

        public async Task<PaymentMethod> AddAsync(PaymentMethod method)
        {
            _context.paymentMethods.Add(method);
            await _context.SaveChangesAsync();
            return method;
        }

        public async Task<PaymentMethod> UpdateAsync(int id, PaymentMethod updated)
        {
            var existing = await _context.paymentMethods.FindAsync(id);
            if (existing == null) return null;

            existing.MethodName = updated.MethodName;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.paymentMethods.FindAsync(id);
            if (existing == null) return false;

            _context.paymentMethods.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
