using SolmileGuesthouseAPI.Data.Models;

namespace SolmileGuesthouseAPI.Interface
{
    public interface PaymentMethodInterface
    {
        Task<IEnumerable<PaymentMethod>> GetAllAsync();
        Task<PaymentMethod> GetByIdAsync(int id);
        Task<PaymentMethod> AddAsync(PaymentMethod method);
        Task<PaymentMethod> UpdateAsync(int id, PaymentMethod updated);
        Task<bool> DeleteAsync(int id);
    }
}
