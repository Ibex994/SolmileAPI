using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;
using SolmileGuesthouseAPI.Helper;
using Microsoft.AspNetCore.Authorization;
using SolmileGuesthouseAPI.Data.Models;
using static System.Net.WebRequestMethods;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin, Manager")]
    public class UsersController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;
        private readonly LogInterface _logInterface;
        private readonly JwtService _jwtService;
        public UsersController(GuesthouseDbContext context, LogInterface logInterface, JwtService jwtService)
        {
            _context = context;
            _logInterface = logInterface;
            _jwtService = jwtService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            return await _context.Users
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password 
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password
            };
        }

        [HttpPut("UpdateUser/{id}")]
        public async Task<IActionResult> PutUser(int id, UInsertionUserDto userDto)
        {


            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Username = userDto.Username;
            user.Password = userDto.Password; 

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPost("lock")]
        public async Task<IActionResult> Lock([FromQuery] int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
                return NotFound("User not found");

            user.IsLocked = true;
            await _context.SaveChangesAsync();

            return Ok("Account locked");
        }

        [HttpGet("IsLocked/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetLockStatus(int id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok(new
            {
                UserId = user.Id,
                IsLocked = user.IsLocked
            });
        }

        [HttpGet("Locked")]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetLockedUsers()
        {
            var lockedUsers = await _context.Users
                .Where(u => u.IsLocked)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password
                })
                .ToListAsync();

            return Ok(lockedUsers);
        }


        [HttpPost("unlock")]
        public async Task<IActionResult> Unlock([FromQuery] int adminId, [FromQuery] int userId)
        {

            var user = await _context.Users.FindAsync(userId);
            if (user == null)
                return NotFound("User not found");

            user.IsLocked = false;
            await _context.SaveChangesAsync();

            return Ok("Account unlocked");
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<UserLoginResponse>> Login([FromBody] LoginDto login)
        {
            if (login == null || !ModelState.IsValid)
                return BadRequest(new UserLoginResponse { IsSuccess = false, Message = "Invalid login request." });

                    var user = await _context.Users
                    .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                    .FirstOrDefaultAsync(u => u.Username.ToLower() == login.Username.ToLower());
            if (user == null)
                return Unauthorized(new UserLoginResponse { IsSuccess = false, Message = "Incorrect username or password." });

            bool isPasswordValid = PasswordHasher.VerifyHashedPassword(user.Password, login.Password);
            if (!isPasswordValid)
                return Unauthorized(new UserLoginResponse { IsSuccess = false, Message = "Incorrect username or password." });

            if (user.IsLocked)
                return Unauthorized(new UserLoginResponse { IsSuccess = false, Message = "Account is locked. Contact admin." });

            var token = _jwtService.GenerateToken(user);

            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Username.ToLower() == user.Username.ToLower());

            return Ok(new UserLoginResponse
            {
                IsSuccess = true,
                Message = "Login successful.",
                Token = token,
                Employee =  new EmployeeDto
                {
                    Id = employee.Id,
                    EmployeePhotoUrl = employee.EmployeePhotoUrl != null ?
            Convert.ToBase64String(employee.EmployeePhotoUrl) : null,
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
                }
            });
        }

        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data");

            var username = User.Identity?.Name?.ToLower(); 
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username.ToLower() == username);


            if (user == null)
                return NotFound("User not found.");

            bool isPasswordValid = PasswordHasher.VerifyHashedPassword(user.Password, dto.CurrentPassword);
            if (!isPasswordValid)
                return Unauthorized("Current password is incorrect.");

            user.Password = PasswordHasher.HashPassword(dto.NewPassword);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Password changed successfully." });
        }

        [HttpPost("forgot-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequestDto dto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username.ToLower() == dto.Username.ToLower());

            if (user == null)
            {
                return BadRequest(new { success = false, message = "User not found" });
            }

            var code = SixDigitCode.GenerateSixDigitCode();

            var otp = new OTP
            {
                Code = code,
                Username = user.Username,
                Reason = "ForgotPassword",
                CreatedAt = DateTime.UtcNow,
                ExpiryAt = DateTime.UtcNow.AddMinutes(10),
                IsUsed = false
            };

            _context.Otps.Add(otp);
            await _context.SaveChangesAsync();

            // TODO: Send code via SMS or email
            return Ok(new
            {
                success = true,
                message = "Password reset code generated and sent.",
                resetCode = code // remove this
            });
        }

        [HttpPost("reset-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPasswordWithCode([FromBody] ResetPasswordWithCodeDto dto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username.ToLower() == dto.Username.ToLower());

            if (user == null)
            {
                return BadRequest(new { success = false, message = "User not found." });
            }

            var otp = await _context.Otps
                .Where(o => o.Username == user.Username && o.Reason == "ForgotPassword" && !o.IsUsed)
                .OrderByDescending(o => o.CreatedAt)
                .FirstOrDefaultAsync();

            if (otp == null || otp.Code != dto.Code || otp.ExpiryAt < DateTime.UtcNow)
            {
                return BadRequest(new { success = false, message = "Invalid or expired reset code." });
            }

            user.Password = PasswordHasher.HashPassword(dto.NewPassword);
            _context.Users.Update(user);

            otp.IsUsed = true;
            _context.Otps.Update(otp);

            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Password has been reset successfully." });
        }
    }
}