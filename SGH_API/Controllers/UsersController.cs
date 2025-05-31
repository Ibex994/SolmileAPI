using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;
using SolmileGuesthouseAPI.Helper;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, Manager")]
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

        //// POST: api/Users
        //[HttpPost]
        //public async Task<ActionResult<UserDto>> PostUser(UserDto userDto)
        //{
        //    var user = new User
        //    {
        //        Username = userDto.Username,
        //        Password = userDto.Password // Note: In production, you should hash the password
        //    };

        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();

        //    userDto.Id = user.Id;
        //    return CreatedAtAction("GetUser", new { id = user.Id }, userDto);
        //}

        // DELETE: api/Users/5
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

            return Ok(new UserLoginResponse
            {
                IsSuccess = true,
                Message = "Login successful.",
                Token = token
            });
        }

        //[Authorize]
        //[HttpGet("protected")]
        //public IActionResult GetProtectedData()
        //{
        //    return Ok("This is protected data only accessible with a valid token.");
        //}
        [HttpPost("reset-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassworDto dto)
        {
            var token = Guid.NewGuid().ToString();

            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Username.ToLower() == dto.Username.ToLower());

            if (user == null)
            {
                return BadRequest(new { success = false, message = "User not found" });
            }
            await _context.SaveChangesAsync();

            user.Password = PasswordHasher.HashPassword(dto.NewPassword);
            user.ResetToken = token;
            user.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(10);

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Password reset successful" });
        }


    }

}
