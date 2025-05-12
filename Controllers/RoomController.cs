using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly RoomInterface _roomInterface;
        private readonly IMapper _mapper;

        public RoomController(RoomInterface roomInterface, IMapper mapper) 
        {
            _roomInterface = roomInterface;
            _mapper = mapper;
        }

        [HttpDelete("{roomId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteRoom(string roomId)
        {
            var result = await _roomInterface.DeleteRoomAsync(roomId);
            return result ? Ok() : NotFound();
        }

        [HttpPatch("{roomId}/status")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateRoomStatus(string roomId, [FromBody] string status)
        {
            var result = await _roomInterface.UpdateRoomStatusAsync(roomId, status);
            return result ? Ok() : NotFound();
        }

        [HttpGet("{roomId}/availability")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> IsAvailable(string roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var available = await _roomInterface.IsAvailableAsync(roomId, checkInDate, checkOutDate);
            return Ok(available);
        }

        [HttpPost("{roomId}/assign")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AssignGuest(string roomId, [FromBody] int customerId)
        {
            var result = await _roomInterface.AssignGuestAsync(roomId, customerId);
            return result ? Ok() : NotFound();
        }

        [HttpGet("{roomId}")]
        [ProducesResponseType(typeof(RoomDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetRoomDetails(string roomId)
        {
            var room = await _roomInterface.GetRoomDetailsAsync(roomId);
            if (room == null) return NotFound();

            var dto = _mapper.Map<RoomDto>(room);
            return Ok(dto);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddRoom([FromBody] CreateRoomDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var branchExists = await _roomInterface.CheckBranchExistsAsync(dto.BranchId);
            if (!branchExists)
            {
                return BadRequest("The specified BranchId does not exist.");
            }
            var roomExists = await _roomInterface.CheckRoomExistsAsync(dto.RoomID);
            if (roomExists)
            {
                return BadRequest("A room with this RoomID already exists.");
            }
            var roomAssignmentExists = await _roomInterface.CheckRoomAssignmentExistsAsync(dto.RoomID);
            if (roomAssignmentExists)
            {
                return BadRequest("A RoomAssignment already exists for this Room.");
            }

            var room = _mapper.Map<Room>(dto);
            room.Status ??= "Available";

            var result = await _roomInterface.AddRoomAsync(room);
            return result ? Ok() : BadRequest("Failed to add room.");
        }

        [HttpPut("{roomId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateRoom(string roomId, [FromBody] RoomDto dto)
        {
            var room = _mapper.Map<Room>(dto);
            var result = await _roomInterface.UpdateRoomAsync(roomId, room);
            return result ? Ok() : NotFound();
        }

    }
}
