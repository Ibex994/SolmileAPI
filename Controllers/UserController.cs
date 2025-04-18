using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    }
}
