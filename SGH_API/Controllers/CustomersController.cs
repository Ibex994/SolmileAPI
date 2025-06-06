using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public CustomersController(GuesthouseDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers()
        {
            return await _context.Customers
                .Select(c => new CustomerDto
                {
                    CustomerId = c.CustomerId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    DateOfBirth = c.DateOfBirth,
                    Gender = c.Gender,
                    Phone = c.Phone,
                    Email = c.Email
                })
                .ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<CustomerDto>> FindCustomerById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return new CustomerDto
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DateOfBirth = customer.DateOfBirth,
                Gender = customer.Gender,
                Phone = customer.Phone,
                Email = customer.Email
            };
        }


        [HttpPost("AddOrUpdate")]
        public async Task<ActionResult<CustomerAddOrUpdateResponse>> AddOrUpdateCustomer(UInsertCustomerDto customerDto)
        {
            var existingCustomer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == customerDto.Email);

            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customerDto.FirstName;
                existingCustomer.LastName = customerDto.LastName;
                existingCustomer.DateOfBirth = customerDto.DateOfBirth;
                existingCustomer.Gender = customerDto.Gender;
                existingCustomer.Phone = customerDto.Phone;

                await _context.SaveChangesAsync();

                return new CustomerAddOrUpdateResponse
                {
                    IsNewCustomer = false,
                    CustomerId= existingCustomer.CustomerId,
                    Customer = customerDto
                };
            }
            else
            {
                var newCustomer = new Customer
                {
                    FirstName = customerDto.FirstName,
                    LastName = customerDto.LastName,
                    DateOfBirth = customerDto.DateOfBirth,
                    Gender = customerDto.Gender,
                    Phone = customerDto.Phone,
                    Email = customerDto.Email
                };

                _context.Customers.Add(newCustomer);
                await _context.SaveChangesAsync();

                customerDto.CustomerId = newCustomer.CustomerId;

                return new CustomerAddOrUpdateResponse
                {
                    IsNewCustomer = true,
                    CustomerId = customerDto.CustomerId,
                    Customer = customerDto
                };
            }
        }
    }

    public class CustomerAddOrUpdateResponse
    {
        public bool IsNewCustomer { get; set; }
        public int CustomerId { get; set; }
        public UInsertCustomerDto Customer { get; set; }
        
    }

}