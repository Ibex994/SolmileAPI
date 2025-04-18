using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class EmployeeRepo : EmployeeInterface
    {
        private readonly DataContext _context;

        public EmployeeRepo(DataContext context )
        {
            _context = context;
        }

        public bool EmployeeExist(int userid)
        {
            return _context.Employees.Any(e => e.Id == userid);   
        }

        public ICollection<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return _context.Employees.Where(e=>e.Email==email).FirstOrDefault();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Where(e => e.Id == id).FirstOrDefault();
        }

        ICollection<Employee> EmployeeInterface.GetEmployeeByGender(string gender)
        {
            return _context.Employees.Where(e => e.Gender.ToLower() == gender.ToLower()).ToList();
        }

        ICollection<Employee> EmployeeInterface.GetEmployeeByStatus(bool status)
        {
            return _context.Employees.Where(es=>es.Status==status).ToList();
        }
    }
}
