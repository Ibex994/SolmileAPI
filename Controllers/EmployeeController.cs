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
        private readonly EmployeeInterface _employeeInterface;
        private readonly IMapper _mapper;

        public EmployeeController(EmployeeInterface employeeInterface, IMapper mapper)
        {
            _employeeInterface = employeeInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type=typeof(IEnumerable<Employee>))]
        [ProducesResponseType(400)]
        public IActionResult GetEmployees()
        {
            var employees = _mapper.Map<List<EmployeeDto>>(_employeeInterface.GetAllEmployees());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employees);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(400)]
        public IActionResult GetEmpById(int id)
        {
            if (!_employeeInterface.EmployeeExist(id))
                return NotFound();
            var employee = _mapper.Map<EmployeeDto>(_employeeInterface.GetEmployeeById(id));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employee);
        }
        [HttpGet("status/{status}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Employee>))]
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
        [HttpGet("gender/{gender}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Employee>))]
        [ProducesResponseType(400)]
       public async Task<IActionResult> GetEmpByGender(string gender)
        {
            var employees =  await _employeeInterface
                .GetEmployeeByGender(gender)
                .ToListAsync();
            var empGender = _mapper.Map<List<EmployeeDto>>(employees);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(empGender);

        }

        [HttpGet("email/{email}")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(400)]
       public async Task<IActionResult> GetEmpByEmail(string email)
        {
            var employee = await _employeeInterface
                .GetEmployeeByEmail(email)
                .ToListAsync();
           
            var empEmail = _mapper.Map<List<EmployeeDto>>(employee);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(empEmail);
        }


        [HttpGet("exists/{userId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult EmployeeExists(int userId)
        {
            var exists = _employeeInterface.EmployeeExist(userId);
            return Ok(exists);
        }

    }
}
