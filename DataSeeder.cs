using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using System;
using System.Threading.Tasks;

namespace SolmileAPI
{
    public class DataSeeder
    {
        private readonly DataContext _context;

        public DataSeeder(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (await _context.Users.AnyAsync())
                return;
            
            // 2. Seed Employees (same Ids as Users)
            var employees = new[]
 {
    new Employee
    {
        Id = 1,
        Username = "admin",
        Password = "admin123",
        FirstName = "Admin",
        LastName = "User",
        Position = "System Administrator",
        Phone = "1234567890",
        Email = "admin@company.com",
        DateOfBirth = new DateTime(1980, 1, 1),
        HireDate = new DateTime(2020, 1, 1),
        Status = true,
        Gender = "Male"
    },
    new Employee
    {
        Id = 2,
        Username = "jdoe",
        Password = "jdoe123",
        FirstName = "John",
        LastName = "Doe",
        Position = "Developer",
        Phone = "9876543210",
        Email = "jdoe@company.com",
        DateOfBirth = new DateTime(1990, 5, 15),
        HireDate = new DateTime(2022, 3, 10),
        Status = true,
        Gender = "Male"
    }
};

            await _context.Employees.AddRangeAsync(employees);
            await _context.SaveChangesAsync();
        }
    }
        }