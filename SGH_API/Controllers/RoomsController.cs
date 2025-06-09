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
    public class RoomsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public RoomsController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDto>>> GetRooms()
        {
            return await _context.Rooms
                .Select(r => new RoomDto
                {
                    RoomId = r.RoomId,
                    RoomNumberAssignmentId = r.RoomNumberAssignmentId,
                    Status = r.Status,
                    TypeId = r.TypeId
                })
                .ToListAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<RoomDto>> findRoomById(string id)
        {
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return new RoomDto
            {
                RoomId = room.RoomId,
                RoomNumberAssignmentId = room.RoomNumberAssignmentId,
                Status = room.Status,
                TypeId = room.TypeId
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(string id, RoomDto roomDto)
        {
            if (id != roomDto.RoomId)
            {
                return BadRequest();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            room.RoomNumberAssignmentId = roomDto.RoomNumberAssignmentId;
            room.Status = roomDto.Status;
            room.TypeId = roomDto.TypeId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
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
        public async Task<ActionResult<RoomDto>> PostRoom(RoomDto roomDto)
        {
            var room = new Room
            {
                RoomId = roomDto.RoomId,
                RoomNumberAssignmentId = roomDto.RoomNumberAssignmentId,
                Status = roomDto.Status,
                TypeId = roomDto.TypeId
            };

            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction("findRoomById", new { id = room.RoomId }, roomDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(string id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("findAvailableRoom")]
        public async Task<ActionResult<RoomDto>> FindAvailableRoom(string location, int roomTypeId, DateTime checkInDate, DateTime checkOutDate)
        {
            var availableRooms = await _context.Rooms
                .Include(r => r.RoomNumberAssignment)
                .ThenInclude(rna => rna.Branch)
                .Include(r => r.RoomType)
                .Where(r =>
                    r.RoomNumberAssignment.Branch.Location == location &&
                    r.TypeId == roomTypeId &&
                    r.Status == "Available")
                .ToListAsync();

            foreach (var room in availableRooms)
            {
                var hasConflict = await _context.Reservations
                    .AnyAsync(r =>
                        r.RoomId == room.RoomId &&
                        r.Status != "Cancelled" &&
                        !(checkOutDate < r.CheckInDate || checkInDate > r.CheckOutDate));

                if (!hasConflict)
                {
                    return new RoomDto
                    {
                        RoomId = room.RoomId,
                        RoomNumberAssignmentId = room.RoomNumberAssignmentId,
                        Status = room.Status,
                        TypeId = room.TypeId
                    };
                }
            }

            return NotFound();
        }

        private bool RoomExists(string id)
        {
            return _context.Rooms.Any(e => e.RoomId == id);
        }
    }


}
