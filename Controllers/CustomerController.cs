using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;
using SolmileAPI.Models;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly CustomerInterface _customerInterface;
        private readonly IMapper _mapper;

        public CustomerController(CustomerInterface customerInterface,IMapper mapper) 
        {
           _customerInterface = customerInterface;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IQueryable<Customer>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllCustomers()
        {
            var customer = _mapper.Map<List<CustomerDto>>(_customerInterface.GetAllCustomers());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(customer);
        }
        [HttpGet("ById")]
        [ProducesResponseType(200, Type = typeof(Customer))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpById(int EmpId)
        {
            if (!_customerInterface.CustomerExist(EmpId))
                return NotFound();
            var Customers = await _customerInterface.GetCustomerById(EmpId);

            if (Customers == null)
                return NotFound();

            var Cust = _mapper.Map<CustomerDto>(Customers);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Cust);
        }

        [HttpGet("email")]
        [ProducesResponseType(200, Type = typeof(CustomerDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpByEmail(string email)
        {
            var customer = await _customerInterface.GetCustomerByEmail(email);
            if (customer == null)
            {
                return NotFound();
            }
            var custEmail = _mapper.Map<CustomerDto>(customer);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(custEmail);
        }

        [HttpGet("customers")]
        [ProducesResponseType(200, Type = typeof(List<CustomerDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetCustomersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("Name parameter is required.");
            }

            var customers = await _customerInterface.GetCustomersByName(name);

            if (customers == null || !customers.Any())
            {
                return NotFound("No customers found with the specified name.");
            }

            var customerDtos = _mapper.Map<List<CustomerDto>>(customers);

            return Ok(customerDtos);
        }


        [HttpGet("exists")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult EmployeeExists(int userId)
        {
            var exists = _customerInterface.CustomerExist(userId);
            return Ok(exists);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerDto createCust)
        {
            if (createCust == null)
                return BadRequest("Customer data is missing.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var customer = await _customerInterface.GetCustomerByEmail(createCust.Email);
            bool customerExists = customer != null;

            if (customerExists)
            {
                ModelState.AddModelError("Email", "Customer with this email already exists.");
                return StatusCode(422, ModelState);
            }
            var newCustomer = _mapper.Map<Customer>(createCust);

            var created = await _customerInterface.CreateCustomer(newCustomer);

            if (!created)
                return StatusCode(500, "An error occurred while creating the customer.");

            return StatusCode(201,"Created Successfully");
        }

        [HttpPut("Update")]
        [ProducesResponseType(200, Type = typeof(CustomerDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] UpdateCust customerDto)
        {
            if (id != customerDto.CustomerId)
            {
                return BadRequest("Customer ID mismatch.");
            }
            var custDto=_mapper.Map<Customer>(customerDto);
            var Update = await _customerInterface.UpdateCustomer(custDto); 
            if (!Update)
            {
                return NotFound("Customer not found.");
            }
            return Ok("Customer updated successfully.");
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteEmployee(int EmpId)
        {
            if (EmpId == 0)
                return BadRequest(ModelState);
            var employeeToDelete = await _customerInterface.GetCustomerById(EmpId);
            if (employeeToDelete == null)
                return NotFound();
            bool deleteSuccessful = await _customerInterface.DeleteCustomer(employeeToDelete);
            if (!deleteSuccessful)
            {
                ModelState.AddModelError("", "Error Deleting Employee");
                return StatusCode(500, ModelState);
            }
            return Ok("Deleted Successfully");
        }
    }

}
