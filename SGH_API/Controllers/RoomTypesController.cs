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
    public class RoomTypesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public RoomTypesController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomTypeDto>>> GetRoomTypes()
        {
            return await _context.RoomTypes
                .Select(r => new RoomTypeDto
                {
                    TypeId = r.TypeId,
                    Name = r.Name,
                    Title = r.Title,
                    Description = r.Description,
                    Amenities = r.Amenities,
                    PricePerNight = r.PricePerNight,
                    Capacity = r.Capacity,
                    ImageUrl = r.ImageUrl
                })
                .ToListAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<RoomTypeDto>> findRoomTypeById(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);

            if (roomType == null)
            {
                return NotFound();
            }

            return new RoomTypeDto
            {
                TypeId = roomType.TypeId,
                Name = roomType.Name,
                Title = roomType.Title,
                Description = roomType.Description,
                Amenities = roomType.Amenities,
                PricePerNight = roomType.PricePerNight,
                Capacity = roomType.Capacity,
                ImageUrl = roomType.ImageUrl
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomType(int id, UpdateRoomTypeDto roomTypeDto)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }

            if (roomTypeDto.ImageUrl != null)
            {
                using var stream = new MemoryStream();
                await roomTypeDto.ImageUrl.CopyToAsync(stream);
                roomType.ImageUrl = stream.ToArray();
            }
   
            roomType.Name = roomTypeDto.Name;
            roomType.Title = roomTypeDto.Title;
            roomType.Description = roomTypeDto.Description;
            roomType.Amenities = roomTypeDto.Amenities;
            roomType.PricePerNight = roomTypeDto.PricePerNight;
            roomType.Capacity = roomTypeDto.Capacity;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomTypeExists(id))
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
        public async Task<ActionResult<RoomTypeDto>> PostRoomType(InsertionRoomTypeDto roomTypeDto)
        {
            var roomType = new RoomType
            {
                TypeId = roomTypeDto.TypeId,
                Name = roomTypeDto.Name,
                Title = roomTypeDto.Title,
                Description = roomTypeDto.Description,
                Amenities = roomTypeDto.Amenities,
                PricePerNight = roomTypeDto.PricePerNight,
                Capacity = roomTypeDto.Capacity,
                ImageUrl = null
            };

            if (roomTypeDto.ImageUrl != null)
            {
                using var stream = new MemoryStream();
                await roomTypeDto.ImageUrl.CopyToAsync(stream);
                roomType.ImageUrl = stream.ToArray();
            }

            _context.RoomTypes.Add(roomType);
            await _context.SaveChangesAsync();

            return new RoomTypeDto
            {
                TypeId = roomType.TypeId,
                Name = roomType.Name,
                Title = roomType.Title,
                Description = roomType.Description,
                Amenities = roomType.Amenities,
                PricePerNight = roomType.PricePerNight,
                Capacity = roomType.Capacity,
                ImageUrl = roomType.ImageUrl
            };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoomType(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }

            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("[action]/{name}")]
        public async Task<ActionResult<RoomTypeDto>> findRoomTypeByName(string name)
        {
            var roomType = await _context.RoomTypes
                .FirstOrDefaultAsync(r => r.Name == name);

            if (roomType == null)
            {
                return NotFound();
            }

            return new RoomTypeDto
            {
                TypeId = roomType.TypeId,
                Name = roomType.Name,
                Title = roomType.Title,
                Description = roomType.Description,
                Amenities = roomType.Amenities,
                PricePerNight = roomType.PricePerNight,
                Capacity = roomType.Capacity,
                ImageUrl = roomType.ImageUrl
            };
        }
        private bool RoomTypeExists(int id)
        {
            return _context.RoomTypes.Any(e => e.TypeId == id);
        }
    }

}
