using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solmile.DTO;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;
using SolmileAPI.Repository;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly userInterface _userInterface;
        private readonly IMapper _mapper;
        private readonly EmployeeInterface _employeeInterface;
        private readonly LogInterface _logInterface;

        public UserController(userInterface userInterface, IMapper mapper, 
            EmployeeInterface employeeInterface, 
            LogInterface logInterface)
        {
            _userInterface = userInterface;
            _mapper = mapper;
            _employeeInterface = employeeInterface;
            _logInterface = logInterface;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var users = _mapper.Map<List<UserDto>>(_userInterface.GetUsers());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(users);
        }

        [HttpGet("id")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public IActionResult GetById(int id)
        { 
            if(!_userInterface.UserExist(id))
                return NotFound();

            var user = _mapper.Map<UserDto>(_userInterface.GetById(id));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);

        }

        [HttpGet("name")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public IActionResult GetByName(string name)
        {
            
            var user = _mapper.Map<UserDto>(_userInterface.GetByName(name));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
        [HttpGet("exists")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult UserExists(int id)
        {
            var exists = _userInterface.UserExist(id);
            return Ok(exists);

        }
        //[HttpPost]
        //[ProducesResponseType(201)]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(422)]
        //[ProducesResponseType(500)]
        //public async Task<IActionResult> CreateUser([FromBody] UserDto userCreate)
        //{
        //    if (userCreate == null)
        //        return BadRequest("User data is missing.");

        //    var existingUser = await _userInterface.GetUsers()
        //        .FirstOrDefaultAsync(u => u.Username.ToLower() == userCreate.Username.ToLower());


        //    if (existingUser != null)
        //    {
        //        ModelState.AddModelError("User", "User already exists.");
        //        return StatusCode(422, ModelState);
        //    }

        //    var user = _mapper.Map<User>(userCreate);

        //    var created = await _userInterface.CreateUserAsync(user);
        //    if (!created)
        //    {
        //        ModelState.AddModelError("", "Something went wrong.");
        //        return StatusCode(500, ModelState);
        //    }

        //    return StatusCode(201, "User created.");
        //}
        [HttpPost("login")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        public async Task<ActionResult> Login([FromBody] LoginDto login)
        {
            if (login == null)
                return BadRequest("User data is missing.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = await _employeeInterface.GetAllEmployees()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == login.Username.ToLower());

            if (existingUser == null || existingUser.Password != login.Password)
                return BadRequest("Invalid username or password.");

            if (!existingUser.Status)
                return BadRequest("Account is deactivated.");

            if (existingUser.IsLocked)
                return BadRequest("Account is locked. Contact admin.");
            await _logInterface.CreateLogAsync("User logged in", LogLevel.Information, existingUser.Id);

            return StatusCode(201, "Successfully Logged In.");
        }


        [HttpPost("resetpassword")]
        public async Task<IActionResult> resetpassword(Resetpassword _data)
        {
            var data = await _userInterface.ResetPassword(_data.username, _data.oldpassword, _data.newpassword);
            return Ok(data);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout(int userId)
        {
            bool result = await _userInterface.Logout(userId);
            return result ? Ok("Logout successful") : NotFound("User not found");
        }

        [HttpPost("lock")]
        public async Task<IActionResult> Lock(int userId)
        {
            bool result = await _userInterface.LockAccount(userId);
            return result ? Ok("Account locked") : NotFound("User not found");
        }

        [HttpPost("unlock")]
        public async Task<IActionResult> Unlock(int adminId, int userId)
        {
            bool result = await _userInterface.UnlockAccount(adminId, userId);
            return result ? Ok("Account unlocked") : NotFound("User not found");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetStaffPassword(int staffId)
        {
            bool result = await _userInterface.ResetStaffPassword(staffId);
            return result ? Ok("Password reset") : NotFound("Staff not found");
        }
    }
    }
