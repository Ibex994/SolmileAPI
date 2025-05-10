using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

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

        // GET: api/Customers
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

        //// GET: api/Customers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        //{
        //    var customer = await _context.Customers.FindAsync(id);

        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return new CustomerDto
        //    {
        //        CustomerId = customer.CustomerId,
        //        FirstName = customer.FirstName,
        //        LastName = customer.LastName,
        //        DateOfBirth = customer.DateOfBirth,
        //        Gender = customer.Gender,
        //        Phone = customer.Phone,
        //        Email = customer.Email
        //    };
        //}

        //// PUT: api/Customers/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCustomer(int id, UInsertCustomerDto customerDto)
        //{
        //    if (id != customerDto.CustomerId)
        //    {
        //        return BadRequest();
        //    }

        //    var customer = await _context.Customers.FindAsync(id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    customer.FirstName = customerDto.FirstName;
        //    customer.LastName = customerDto.LastName;
        //    customer.DateOfBirth = customerDto.DateOfBirth;
        //    customer.Gender = customerDto.Gender;
        //    customer.Phone = customerDto.Phone;
        //    customer.Email = customerDto.Email;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CustomerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Customers
        //[HttpPost]
        //public async Task<ActionResult<CustomerDto>> PostCustomer(CustomerDto customerDto)
        //{
        //    var customer = new Customer
        //    {
        //        FirstName = customerDto.FirstName,
        //        LastName = customerDto.LastName,
        //        DateOfBirth = customerDto.DateOfBirth,
        //        Gender = customerDto.Gender,
        //        Phone = customerDto.Phone,
        //        Email = customerDto.Email
        //    };

        //    _context.Customers.Add(customer);
        //    await _context.SaveChangesAsync();

        //    customerDto.CustomerId = customer.CustomerId;
        //    return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customerDto);
        //}

        // DELETE: api/Customers/5
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
        // GET: api/Customer/FindById/5
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

        // POST: api/Customer/AddOrUpdate
        [HttpPost("AddOrUpdate")]
        public async Task<ActionResult<CustomerAddOrUpdateResponse>> AddOrUpdateCustomer(UInsertCustomerDto customerDto)
        {
            var existingCustomer = await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == customerDto.Email);

            if (existingCustomer != null)
            {
                // Update existing customer
                existingCustomer.FirstName = customerDto.FirstName;
                existingCustomer.LastName = customerDto.LastName;
                existingCustomer.DateOfBirth = customerDto.DateOfBirth;
                existingCustomer.Gender = customerDto.Gender;
                existingCustomer.Phone = customerDto.Phone;

                await _context.SaveChangesAsync();

                return new CustomerAddOrUpdateResponse
                {
                    IsNewCustomer = false,
                    Customer = customerDto
                };
            }
            else
            {
                // Add new customer
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
                    Customer = customerDto
                };
            }
        }
    }

    public class CustomerAddOrUpdateResponse
    {
        public bool IsNewCustomer { get; set; }
        public UInsertCustomerDto Customer { get; set; }
    }

}