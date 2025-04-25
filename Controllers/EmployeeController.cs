using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly userInterface _userInterface;
        private readonly EmployeeInterface _employeeInterface;
        private readonly IMapper _mapper;

        public EmployeeController(userInterface userInterface, EmployeeInterface employeeInterface, IMapper mapper)
        {
            _userInterface = userInterface;
            _employeeInterface = employeeInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EmployeeDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetEmployees()
        {
            var employees = _mapper.Map<List<EmployeeDto>>(_employeeInterface.GetAllEmployees());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employees);
        }

        [HttpGet("ById")]
        [ProducesResponseType(200, Type = typeof(EmployeeDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpById(int EmpId)
        {
            if (!_employeeInterface.EmployeeExist(EmpId))
                return NotFound();

            var employeeEntity = await _employeeInterface.GetEmployeeById(EmpId);

            if (employeeEntity == null)
                return NotFound();

            var employeeDto = _mapper.Map<EmployeeDto>(employeeEntity);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(employeeDto);
        }

        [HttpGet("status")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EmployeeDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpByStatus(bool status)
        {
            var employees = await _employeeInterface
                .GetEmployeeByStatus(status)
                .ToListAsync();

            var empStatus = _mapper.Map<List<EmployeeDto>>(employees);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(empStatus);
        }
        [HttpGet("gender")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EmployeeDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpByGender(string gender)
        {
            var employees = await _employeeInterface
                .GetEmployeeByGender(gender)
                .ToListAsync();
            var empGender = _mapper.Map<List<EmployeeDto>>(employees);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(empGender);

        }

        [HttpGet("email")]
        [ProducesResponseType(200, Type = typeof(EmployeeDto))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpByEmail(string email)
        {
            var employee = await _employeeInterface
                .GetEmployeeByEmail(email);

            var empEmail = _mapper.Map<EmployeeDto>(employee);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(empEmail);
        }
        [HttpGet("position")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EmployeeDto>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetEmpByPos(string position)
        {
            var empPos = await _employeeInterface
                .GetEmployeeByPos(position)
                .ToListAsync();
            if (!ModelState.IsValid)
                ModelState.AddModelError("Position", "No employee found with this position.");
            return Ok(empPos);
        }

        [HttpGet("exists")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult EmployeeExists(int userId)
        {
            var exists = _employeeInterface.EmployeeExist(userId);
            return Ok(exists);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ProducesResponseType(500)]
        [HttpPost]
        public async Task<IActionResult> CreateEmployees([FromBody] EmployeeDto createEmp)
        {
            if (createEmp == null)
                return BadRequest("Employee data is missing.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bool employeeExists = await _employeeInterface.GetAllEmployees()
                .AnyAsync(e => e.Email.ToLower() == createEmp.Email.ToLower());

            if (employeeExists)
            {
                ModelState.AddModelError("Email", "Employee with this email already exists.");
                return StatusCode(422, ModelState);
            }
            string Username;
            do
            {
                var random = new Random();
                int randomNumber = random.Next(1000, 9999);
                Username = $"{createEmp.FirstName.ToLower()}@{randomNumber}";
            }
            while (await _userInterface.GetUsers().AnyAsync(u => u.Username == Username));

            string username = Username;
            string tempPassword = Guid.NewGuid().ToString();

            createEmp.Username = username;
            createEmp.Password = tempPassword;

            var user = new User
            {
                Username = username,
                Password = tempPassword
            };

            var employee = _mapper.Map<Employee>(createEmp);
            employee.User = user;

            var employeeCreated = await _employeeInterface.CreateEmployee(employee);

            if (!employeeCreated)
            {
                ModelState.AddModelError("", "Failed to create employee and user.");
                return StatusCode(500, ModelState);
            }

            return Ok(new
            {
                Message = "Employee successfully created.",
                Username = user.Username,
                TemporaryPassword = tempPassword
            });
        }

        [HttpPut("Update")]
        [ProducesResponseType(200, Type = typeof(EmployeeDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateEmployee(int EmpId, [FromBody] UpdateDto updateDto)
        {
            if (updateDto == null)
                return BadRequest(ModelState);

            if (EmpId != updateDto.Id)
                return BadRequest(ModelState);

            var existingEmployee = await _employeeInterface.GetEmployeeById(EmpId);
            if (existingEmployee == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _mapper.Map(updateDto, existingEmployee);

            bool updateSuccessful = await _employeeInterface.UpdateEmployee(existingEmployee);
            if (!updateSuccessful)
            {
                ModelState.AddModelError("", "Error Updating Employee");
                return StatusCode(500, ModelState);
            }

            return Ok("Updated Successfully");
        }

        [HttpDelete("EmpId")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteEmployee(int EmpId)
        {
            if (EmpId == 0)
                return BadRequest(ModelState);
            var employeeToDelete = await _employeeInterface.GetEmployeeById(EmpId);
            if (employeeToDelete == null)
                return NotFound();
            bool deleteSuccessful = await _employeeInterface.DeleteEmployee(employeeToDelete);
            if (!deleteSuccessful)
            {
                ModelState.AddModelError("", "Error Deleting Employee");
                return StatusCode(500, ModelState);
            }
            return Ok("Deleted Successfully");
        }
    }
}
