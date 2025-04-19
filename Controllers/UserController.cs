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
    public class UserController : Controller
    {
        private readonly userInterface _userInterface;
        private readonly IMapper _mapper;

        public UserController(userInterface userInterface, IMapper mapper)
        {
            _userInterface = userInterface;
            _mapper = mapper;
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

        [HttpGet("{id}")]
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

        [HttpGet("name/{name}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public IActionResult GetByName(string name)
        {
            
            var user = _mapper.Map<UserDto>(_userInterface.GetByName(name));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
        [HttpGet("exists/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult UserExists(int id)
        {
            var exists = _userInterface.UserExist(id);
            return Ok(exists);

        }
        //[HttpPost]
        //[ProducesResponseType(204)]
        //[ProducesResponseType(400)]
        //public IActionResult CreateUser([FromBody] UserDto usercreate)
        //{
        //    if(usercreate == null)
        //        return BadRequest("User data is missing.");
        //    //var user = _userInterface.GetUsers()
        //    //    .Where(u => u.Id == usercreate.Id)
        //    //    .FirstOrDefault();
        //    var user = _userInterface.GetUsers()
        //        .FirstOrDefault(u => u.Username.ToLower() == usercreate.Username.ToLower());

        //    if (user != null)
        //    {
        //        ModelState.AddModelError("", "User Alredy Eixts");
        //        return StatusCode(422,ModelState);
        //    }
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);
        //    var userMap = _mapper.Map<User>(usercreate);
        //    if(!_userInterface.CreateUserAsync(userMap))
        //    {
        //        ModelState.AddModelError("", "Something Went Wrong While Creating User");
        //        return StatusCode(500,ModelState);
        //    }
        //    return StatusCode(201, "Successfully created user.");
        //}
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userCreate)
        {
            if (userCreate == null)
                return BadRequest("User data is missing.");

            var existingUser = await _userInterface.GetUsers()
                .FirstOrDefaultAsync(u => u.Username.ToLower() == userCreate.Username.ToLower());


            if (existingUser != null)
            {
                ModelState.AddModelError("User", "User already exists.");
                return StatusCode(422, ModelState);
            }

            var user = _mapper.Map<User>(userCreate);

            var created = await _userInterface.CreateUserAsync(user);
            if (!created)
            {
                ModelState.AddModelError("", "Something went wrong.");
                return StatusCode(500, ModelState);
            }

            return StatusCode(201, "User created.");
        }


    }
}
