using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileAPI.DTO;
using SolmileAPI.Interface;

namespace SolmileAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class RoomAssignmentController : Controller
        {
            private readonly RoomAssignmentInterface _roomAssignmentRepository;
            private readonly IMapper _mapper;

            public RoomAssignmentController(RoomAssignmentInterface roomAssignmentRepository, IMapper mapper)
            {
                _roomAssignmentRepository = roomAssignmentRepository;
                _mapper = mapper;
            }

        // 1. Assign room number to a branch
        [HttpPost("assign")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AssignRoomNumber([FromBody] RoomAssignmentDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Check if the BranchId exists
            var branchExists = await _roomAssignmentRepository.CheckBranchExistsAsync(dto.BranchId);
            if (!branchExists)
            {
                return BadRequest("The specified BranchId does not exist.");
            }

            // Check if the room exists
            var roomExists = await _roomAssignmentRepository.CheckRoomExistsAsync(dto.RoomID);
            if (!roomExists)
            {
                return BadRequest("The specified Room does not exist.");
            }

            var result = await _roomAssignmentRepository.AssignRoomNumberAsync(dto.BranchId, int.Parse(dto.RoomID));
            if (result)
                return Ok("Room number assigned successfully.");

            return BadRequest("Failed to assign room number.");
        }


        // 2. Update room assignment with a new room number
        [HttpPut("update/{assignmentId}")]
            [ProducesResponseType(200)]
            [ProducesResponseType(400)]
            public async Task<IActionResult> UpdateRoomAssignment(int assignmentId, [FromBody] RoomAssignmentDto dto)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var result = await _roomAssignmentRepository.UpdateRoomAssignmentAsync(assignmentId, int.Parse(dto.RoomID));
                if (result)
                    return Ok("Room assignment updated successfully.");
                return BadRequest("Failed to update room assignment.");
            }

        // 3. Delete room assignment by RoomNumberAssignmentId
        [HttpDelete("delete/{assignmentId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> DeleteRoomAssignment(int assignmentId)
        {
            // Check if the RoomAssignmentId exists before deleting
            var roomAssignmentExists = await _roomAssignmentRepository.RoomAssignmentExistsAsync(assignmentId);
            if (!roomAssignmentExists)
            {
                return BadRequest("Room assignment not found.");
            }

            var result = await _roomAssignmentRepository.DeleteRoomAssignmentAsync(assignmentId);
            if (result)
            {
                return Ok("Room assignment deleted successfully.");
            }

            return BadRequest("Failed to delete room assignment.");
        }


        // 4. Get all room assignments for a specific branch
        [HttpGet("branch/{branchId}")]
            [ProducesResponseType(200, Type = typeof(List<RoomAssignmentDto>))]
            [ProducesResponseType(404)]
            public async Task<IActionResult> GetRoomAssignmentsByBranch(int branchId)
            {
                var roomAssignments = await _roomAssignmentRepository.GetRoomAssignmentsByBranchAsync(branchId);
                if (roomAssignments == null || roomAssignments.Count == 0)
                    return NotFound("No room assignments found for the given branch.");

                // Map RoomAssignment entities to RoomAssignmentDto
                var roomAssignmentsDto = _mapper.Map<List<RoomAssignmentDto>>(roomAssignments);

                return Ok(roomAssignmentsDto);
            }
        }
 }
