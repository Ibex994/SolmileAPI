using SolmileAPI.Models;

namespace SolmileAPI.Interface
{
    public interface CustomerInterface
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<List<Customer>> GetCustomersByName(string name);
        Task<Customer> GetCustomerByEmail(string email);
        bool CustomerExist(int userid);
        Task<bool> UpdateCustomer(Customer customer);
        Task<bool> CreateCustomer(Customer customer);
        Task<bool> DeleteCustomer(Customer customer);
        Task<bool> SaveAsync();


    }
}
