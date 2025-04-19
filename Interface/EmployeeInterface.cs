using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface EmployeeInterface
    {
        IQueryable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        IQueryable<Employee> GetEmployeeByStatus(bool status);
        IQueryable<Employee> GetEmployeeByGender(string gender);
        IQueryable<Employee> GetEmployeeByEmail(string email);
        bool  EmployeeExist(int userid);
        Task <bool> CreateEmployee(Employee employee);
        Task <bool> Save();

    }
}
