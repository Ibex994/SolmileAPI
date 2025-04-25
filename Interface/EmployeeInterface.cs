using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface EmployeeInterface
    {
        IQueryable<Employee> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        IQueryable<Employee> GetEmployeeByStatus(bool status);
        IQueryable<Employee> GetEmployeeByGender(string gender);
        Task<Employee> GetEmployeeByEmail(string email);
        IQueryable<Employee> GetEmployeeByPos(string Posn);
        bool  EmployeeExist(int userid);
        Task <bool> CreateEmployee(Employee employee);
        Task <bool> UpdateEmployee(Employee employee);
        Task <bool> DeleteEmployee(Employee employee);
        Task <bool> Save();

    }
}
