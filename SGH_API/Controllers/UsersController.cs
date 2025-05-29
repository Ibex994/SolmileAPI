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

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            return await _context.Users
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password // Note: In production, you should never expose passwords
                })
                .ToListAsync();
        }

        // GET: api/Users/5
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
                Password = user.Password // Note: In production, you should never expose passwords
            };
        }

        // PUT: api/Users/5
        [HttpPut("UpdateUser/{id}")]
        public async Task<IActionResult> PutUser(int id, UInsertionUserDto userDto)
        {


            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Username = userDto.Username;
            user.Password = userDto.Password; // Note: In production, you should hash the password

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

        // POST: api/Users/lock
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
        // GET: api/Users/IsLocked/5
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

        // GET: api/Users/Locked
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
                    Password = u.Password // ⚠️ Do not include this in production
                })
                .ToListAsync();

            return Ok(lockedUsers);
        }


        // POST: api/Users/unlock
        [HttpPost("unlock")]
        public async Task<IActionResult> Unlock([FromQuery] int adminId, [FromQuery] int userId)
        {
            // You could verify the adminId here if needed

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
        [HttpPost("Login")]
        [ProducesResponseType(typeof(UserLoginResponse), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<UserLoginResponse>> Login([FromBody] LoginDto login)
        {
            if (login == null || !ModelState.IsValid)
                return BadRequest(new UserLoginResponse { IsSuccess = false, Message = "Invalid login request." });

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username.ToLower() == login.Username.ToLower() && u.Password == login.Password);

            if (user == null)
                return Unauthorized(new UserLoginResponse { IsSuccess = false, Message = "Incorrect username or password." });

            if (user.IsLocked)
                return Unauthorized(new UserLoginResponse { IsSuccess = false, Message = "Account is locked. Contact admin." });

            var token = _jwtService.GenerateToken(user);

            return Ok(new UserLoginResponse
            {
                IsSuccess = true,
                Message = "Login successful.",
                Token = token,
                User = new UserDto
                {
                    Id = user.Id,
                    Username = user.Username
                    // Optional: Do NOT return password
                }
            });
        }
        //[Authorize]
        //[HttpGet("protected")]
        //public IActionResult GetProtectedData()
        //{
        //    return Ok("This is protected data only accessible with a valid token.");
        //}

    }
}
