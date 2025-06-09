using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class RoomNumberAssignmentsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public RoomNumberAssignmentsController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomNumberAssignmentDto>>> GetRoomNumberAssignments()
        {
            return await _context.RoomNumberAssignments
                .Select(r => new RoomNumberAssignmentDto
                {
                    RoomNumberAssignmentId = r.RoomNumberAssignmentId,
                    BranchId = r.BranchId,
                    RoomNumber = r.RoomNumber
                })
                .ToListAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<RoomNumberAssignmentDto>> findRoomNumberAssignmentById(int id)
        {
            var roomNumberAssignment = await _context.RoomNumberAssignments.FindAsync(id);

            if (roomNumberAssignment == null)
            {
                return NotFound();
            }

            return new RoomNumberAssignmentDto
            {
                RoomNumberAssignmentId = roomNumberAssignment.RoomNumberAssignmentId,
                BranchId = roomNumberAssignment.BranchId,
                RoomNumber = roomNumberAssignment.RoomNumber
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomNumberAssignment(int id, UInsertionRoomNumberAssignmentDto roomNumberAssignmentDto)
        {
            

            var roomNumberAssignment = await _context.RoomNumberAssignments.FindAsync(id);
            if (roomNumberAssignment == null)
            {
                return NotFound();
            }

            roomNumberAssignment.BranchId = roomNumberAssignmentDto.BranchId;
            roomNumberAssignment.RoomNumber = roomNumberAssignmentDto.RoomNumber;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomNumberAssignmentExists(id))
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

        [HttpPost]
        public async Task<ActionResult<RoomNumberAssignmentDto>> PostRoomNumberAssignment(UInsertionRoomNumberAssignmentDto roomNumberAssignmentDto)
        {
            var roomNumberAssignment = new RoomNumberAssignment
            {
                BranchId = roomNumberAssignmentDto.BranchId,
                RoomNumber = roomNumberAssignmentDto.RoomNumber
            };

            _context.RoomNumberAssignments.Add(roomNumberAssignment);
            await _context.SaveChangesAsync();

            roomNumberAssignmentDto.RoomNumberAssignmentId = roomNumberAssignment.RoomNumberAssignmentId;
            return new RoomNumberAssignmentDto
            {
                RoomNumberAssignmentId = roomNumberAssignment.RoomNumberAssignmentId,
                BranchId = roomNumberAssignment.BranchId,
                RoomNumber = roomNumberAssignment.RoomNumber
            };


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomNumberAssignment(int id)
        {
            var roomNumberAssignment = await _context.RoomNumberAssignments.FindAsync(id);
            if (roomNumberAssignment == null)
            {
                return NotFound();
            }

            _context.RoomNumberAssignments.Remove(roomNumberAssignment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoomNumberAssignmentExists(int id)
        {
            return _context.RoomNumberAssignments.Any(e => e.RoomNumberAssignmentId == id);
        }
    }


}
