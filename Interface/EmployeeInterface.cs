using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface EmployeeInterface
    {
        ICollection<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        ICollection<Employee> GetEmployeeByStatus(bool status);
        ICollection <Employee> GetEmployeeByGender(string gender);
        Employee GetEmployeeByEmail(string email);
        bool  EmployeeExist(int userid);

    }
}
