using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using SolmileGuesthouseAPI.Interface;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Manager,HR")]
    public class EmployeesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;
        private readonly LogInterface _logInterface;

        public EmployeesController(GuesthouseDbContext context, LogInterface logInterface)
        {
            _context = context;
            _logInterface = logInterface;
        }

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
                    BranchId = e.BranchId,
                    EmployeePhotoUrl = e.EmployeePhotoUrl != null ?
            Convert.ToBase64String(e.EmployeePhotoUrl) : null,
                })
                .ToListAsync();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, UpdateEmployeeDto employeeDto)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            byte[]? photoBytes = null;

            if (employeeDto.EmployeePhotoUrl != null && employeeDto.EmployeePhotoUrl.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await employeeDto.EmployeePhotoUrl.CopyToAsync(memoryStream);
                    photoBytes = memoryStream.ToArray();
                }
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
            employee.EmployeePhotoUrl = photoBytes;

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
        [HttpPost("CreateAccount")]
        public async Task<ActionResult<EmployeeDto>> PostEmployee(InsertionEmployeeDto employeeDto)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                
                bool employeeExists = await _context.Employees
                    .AnyAsync(e => e.Email.ToLower() == employeeDto.Email.ToLower());

                if (employeeExists)
                {
                    return StatusCode(422, new { message = "Employee with this email already exists." });
                }

            
                string Username;
                do
                {
                    var random = new Random();
                    int randomNumber = random.Next(1000, 9999);
                    Username = $"{employeeDto.FirstName.ToLower()}@{randomNumber}";
                }
                while (await _context.Employees.AnyAsync(e => e.Username == Username));

                string tempPassword = Guid.NewGuid().ToString().Substring(0, 8);

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(tempPassword);

                byte[]? photoBytes = null;
                if (employeeDto.EmployeePhotoUrl != null && employeeDto.EmployeePhotoUrl.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await employeeDto.EmployeePhotoUrl.CopyToAsync(memoryStream);
                        photoBytes = memoryStream.ToArray();
                    }
                }

                var employee = new Employee
                {
                    Username = Username,
                    Password = hashedPassword,
                    FirstName = employeeDto.FirstName,
                    LastName = employeeDto.LastName,
                    Position = employeeDto.Position,
                    Phone = employeeDto.Phone,
                    Email = employeeDto.Email,
                    DateOfBirth = employeeDto.DateOfBirth,
                    HireDate = employeeDto.HireDate,
                    Status = employeeDto.Status,
                    Gender = employeeDto.Gender,
                    BranchId = employeeDto.BranchId,
                    EmployeePhotoUrl = photoBytes
                };

                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();

                var role = await _context.Roles.FirstOrDefaultAsync(r => r.Name == employee.Position);
                if (role == null)
                {
                    await transaction.RollbackAsync();
                    return BadRequest($"No role found matching position: '{employee.Position}'.");
                }

                _context.UserRoles.Add(new UserRole
                {
                    UserId = employee.Id,
                    RoleId = role.Id
                });

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return Ok(new
                {
                    message = "Employee successfully created.",
                    employee = new EmployeeDto
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
                        BranchId = employee.BranchId,
                         EmployeePhotoUrl = employee.EmployeePhotoUrl != null ? 
                                                Convert.ToBase64String(employee.EmployeePhotoUrl) : null,
                    },
                    temporaryPassword = tempPassword
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, $"Account creation failed: {ex.Message}");
            }
        }

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
                BranchId = employee.BranchId,
                EmployeePhotoUrl = employee.EmployeePhotoUrl != null ?
            Convert.ToBase64String(employee.EmployeePhotoUrl) : null
            };
        }
        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> SearchEmployees(
                                                            [FromQuery] string? email,
                                                            [FromQuery] string? gender,
                                                            [FromQuery] string? position,
                                                            [FromQuery] bool? status)
        {
            var query = _context.Employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(email))
            {
                var emailLower = email.Trim().ToLower();
                query = query.Where(e => e.Email != null && e.Email.ToLower().Contains(emailLower));
            }

            if (!string.IsNullOrWhiteSpace(gender))
            {
                query = query.Where(e => e.Gender != null && e.Gender.ToLower() == gender.ToLower());
            }

            if (!string.IsNullOrWhiteSpace(position))
            {
                query = query.Where(e => e.Position != null && e.Position.ToLower().Contains(position.ToLower()));
            }

            if (status.HasValue)
            {
                query = query.Where(e => e.Status == status.Value);
            }

            var results = await query
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
                    BranchId = e.BranchId,
                    EmployeePhotoUrl = e.EmployeePhotoUrl != null ?
            Convert.ToBase64String(e.EmployeePhotoUrl) : null,
                })
                .ToListAsync();

            if (results.Count == 0)
            {
                return NotFound("No employees matched the search criteria.");
            }

            return Ok(results);
        }


    }
}