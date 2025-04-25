using Microsoft.EntityFrameworkCore;
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

        public Task<bool> DeleteEmployee(Employee employee)
        {
            _context.Remove(employee);
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

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
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

        public Task<bool> UpdateEmployee(Employee employee)
        {
           _context.Update(employee);
            return Save();
        }

        IQueryable<Employee> EmployeeInterface.GetAllEmployees()
        {
            return _context.Employees.AsQueryable();
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

    }
}
