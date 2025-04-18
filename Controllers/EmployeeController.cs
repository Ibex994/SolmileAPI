using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetEmpByStatus(bool status, int id)
        {
            if (!_employeeInterface.EmployeeExist(id))
                return NotFound();
            var employees = _mapper.Map<IEnumerable<EmployeeDto>>(_employeeInterface.GetEmployeeByStatus(status));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employees);
        }
        [HttpGet("gender/{gender}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Employee>))]
        [ProducesResponseType(400)]
        public IActionResult GetEmpByGender(string gender, int id)
        {
            if (!_employeeInterface.EmployeeExist(id))
                return NotFound();
            var employees=_mapper.Map<IEnumerable<Employee>>(_employeeInterface.GetEmployeeByGender(gender));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employees);
        }
        [HttpGet("email/{email}")]
        [ProducesResponseType(200, Type = typeof(Employee))]
        [ProducesResponseType(400)]
        public IActionResult GetEmpByEmail(string email, int id)
        {
            if (!_employeeInterface.EmployeeExist(id))
                return NotFound();
            var employee = _mapper.Map<EmployeeDto>(_employeeInterface.GetEmployeeByEmail(email));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(employee);
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
