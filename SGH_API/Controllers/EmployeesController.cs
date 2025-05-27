    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SolmileGuesthouseAPI.Data.Models;
    using SolmileGuesthouseAPI.Data;
    using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
    using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;
        private readonly LogInterface _logInterface;

        public EmployeesController(GuesthouseDbContext context, LogInterface logInterface)
        {
            _context = context;
            _logInterface = logInterface;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees()
        {
            return await _context.Employees
                .Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    Username = e.Username,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Position = e.Position,
                    Phone = e.Phone,
                    Email = e.Email,
                    DateOfBirth = e.DateOfBirth,
                    HireDate = e.HireDate,
                    Status = e.Status,
                    Gender = e.Gender,
                    BranchId = e.BranchId
                })
                .ToListAsync();
        }

        //// GET: api/Employees/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<EmployeeDto>> GetEmployee(int id)
        //{
        //    var employee = await _context.Employees.FindAsync(id);

        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return new EmployeeDto
        //    {
        //        Id = employee.Id,
        //        Username = employee.Username,
        //        FirstName = employee.FirstName,
        //        LastName = employee.LastName,
        //        Position = employee.Position,
        //        Phone = employee.Phone,
        //        Email = employee.Email,
        //        DateOfBirth = employee.DateOfBirth,
        //        HireDate = employee.HireDate,
        //        Status = employee.Status,
        //        Gender = employee.Gender,
        //        BranchId = employee.BranchId
        //    };
        //}

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, UpdateEmployeeDto employeeDto)
        {


            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.FirstName = employeeDto.FirstName;
            employee.LastName = employeeDto.LastName;
            employee.Position = employeeDto.Position;
            employee.Phone = employeeDto.Phone;
            employee.Email = employeeDto.Email;
            employee.DateOfBirth = employeeDto.DateOfBirth;
            employee.HireDate = employeeDto.HireDate;
            employee.Status = employeeDto.Status;
            employee.Gender = employeeDto.Gender;
            employee.BranchId = employeeDto.BranchId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        [HttpPost("CreateAccount")]
        public async Task<ActionResult<EmployeeDto>> PostEmployee(InsertionEmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                Username = employeeDto.Username,
                Password = employeeDto.Password,
                FirstName = employeeDto.FirstName,
                LastName = employeeDto.LastName,
                Position = employeeDto.Position,
                Phone = employeeDto.Phone,
                Email = employeeDto.Email,
                DateOfBirth = employeeDto.DateOfBirth,
                HireDate = employeeDto.HireDate,
                Status = employeeDto.Status,
                Gender = employeeDto.Gender,
                BranchId = employeeDto.BranchId
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();


            // return CreatedAtAction("FindEmployeeById", new { id = employee.Id }, employeeDto);

            return new EmployeeDto
            {
                Id = employee.Id,
                Username = employee.Username,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Position = employee.Position,
                Phone = employee.Phone,
                Email = employee.Email,
                DateOfBirth = employee.DateOfBirth,
                HireDate = employee.HireDate,
                Status = employee.Status,
                Gender = employee.Gender,
                BranchId = employee.BranchId
            };

        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

        // GET: api/EmployeeExtensions/FindById/5
        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<EmployeeDto>> FindEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return new EmployeeDto
            {
                Id = employee.Id,
                Username = employee.Username,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Position = employee.Position,
                Phone = employee.Phone,
                Email = employee.Email,
                DateOfBirth = employee.DateOfBirth,
                HireDate = employee.HireDate,
                Status = employee.Status,
                Gender = employee.Gender,
                BranchId = employee.BranchId
            };
        }

        // POST: api/EmployeeExtensions/Login
        [HttpPost("Login")]
        public async Task<ActionResult<EmployeeLoginResponse>> Login(EmployeeLoginRequest loginRequest)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Username == loginRequest.Username && e.Password == loginRequest.Password);

            if (employee == null)
            {
                return Unauthorized(new { message = "Incorrect credentials." });
            }

            if (!employee.Status)
            {
                return Unauthorized(new { message = "Account is disabled." });
            }

            if (employee.IsLocked)
            {
                return Unauthorized(new { message = "Account is locked. Please contact admin." });
            }

            
            await _logInterface.CreateLogAsync("User logged in", LogLevel.Information, employee.Id, employee.FirstName, employee.LastName);

            return new EmployeeLoginResponse
            {
                Employee = new EmployeeDto
                {
                    Id = employee.Id,
                    Username = employee.Username,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Position = employee.Position,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    DateOfBirth = employee.DateOfBirth,
                    HireDate = employee.HireDate,
                    Status = employee.Status,
                    Gender = employee.Gender,
                    BranchId = employee.BranchId
                },
                IsSuccess = true
            };
        }


        public class EmployeeLoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class EmployeeLoginResponse
        {
            public bool IsSuccess { get; set; }
            public EmployeeDto Employee { get; set; }
        }
    }
}