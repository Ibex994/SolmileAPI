using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class EmployeeRepo : EmployeeInterface
    {
        private readonly DataContext _context;

        public EmployeeRepo(DataContext context)
        {
            _context = context;
        }

        public Task<bool> CreateEmployee(Employee employee)
        {
           _context.AddAsync(employee);
            return Save();
        }

        public bool EmployeeExist(int userid)
        {
            return _context.Employees.Any(e => e.Id == userid);   
        }

        public IQueryable<Employee> GetEmployeeByGender(string gender)
        {
            return _context.Employees.Where(e => e.Gender.ToLower() == gender.ToLower());
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public IQueryable<Employee> GetEmployeeByPos(string Posn)
        {
            return _context.Employees.Where(e => e.Position.ToLower() == Posn.ToLower());
        }

        public IQueryable<Employee> GetEmployeeByStatus(bool status)
        {
            return _context.Employees.Where(es => es.Status == status);
        }

        public async Task<bool> Save()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        IQueryable<Employee> EmployeeInterface.GetAllEmployees()
        {
            return _context.Employees.AsQueryable();
        }

        IQueryable<Employee> EmployeeInterface.GetEmployeeByEmail(string email)
        {
            return _context.Employees.Where(e => e.Email == email);
        }
    }
}
