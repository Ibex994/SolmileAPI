using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using System.Security.Cryptography;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public RoomTypesController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/RoomTypes
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

        // GET: api/RoomTypes/5
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

        // PUT: api/RoomTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomType(int id, UpdateRoomTypeDto roomTypeDto)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }

            // Only update image if a new one is provided
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

        // POST: api/RoomTypes
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
                ImageUrl = null // Initialize as null
            };

            // Only process image if provided
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

        // DELETE: api/RoomTypes/5
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

        // GET: api/RoomTypes/findByName/Standard
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
