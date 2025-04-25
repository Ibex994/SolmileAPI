using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;
using SolmileAPI.Models;

namespace SolmileAPI.Repository
{
    public class CustomerRepo : CustomerInterface
    {
        private readonly DataContext _context;

        public CustomerRepo(DataContext context) {
            _context = context;
        }
        public Task<bool> CreateCustomer(Customer customer)
        {
            _context.AddAsync(customer);
            return SaveAsync();
        }

        public bool CustomerExist(int userid)
        {
            return _context.Customers.Any(e => e.CustomerId == userid);
        }

        public Task<bool> DeleteCustomer(Customer customer)
        {
            _context.Remove(customer);
            return SaveAsync();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
        }

        public async Task<List<Customer>> GetCustomersByName(string name)
        {
            return await _context.Customers
                .Where(c => c.FirstName.Contains(name) || c.LastName.Contains(name))
                .ToListAsync();
        }


        public async Task<bool> SaveAsync()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public Task<bool> UpdateCustomer(Customer customer)
        {
             _context.Update(customer);
            return SaveAsync();
        }
    }
}
