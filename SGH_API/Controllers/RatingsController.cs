using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public RatingsController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/Ratings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RatingDto>>> GetRatings()
        {
            return await _context.Ratings
                .Select(r => new RatingDto
                {
                    RatingId = r.RatingId,
                    EmployeeId = r.EmployeeId,
                    ServiceRequestId = r.ServiceRequestId,
                    RatingValue = r.RatingValue,
                    RatingDate = r.RatingDate,
                    GivenBy = r.GivenBy,
                    GivenReason = r.GivenReason
                })
                .ToListAsync();
        }

        // GET: api/Ratings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RatingDto>> GetRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
            {
                return NotFound();
            }

            return new RatingDto
            {
                RatingId = rating.RatingId,
                EmployeeId = rating.EmployeeId,
                ServiceRequestId = rating.ServiceRequestId,
                RatingValue = rating.RatingValue,
                RatingDate = rating.RatingDate,
                GivenBy = rating.GivenBy,
                GivenReason = rating.GivenReason
            };
        }

        // PUT: api/Ratings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, UInsertionRatingDto ratingDto)
        {
            if (id != ratingDto.RatingId)
            {
                return BadRequest();
            }

            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            rating.EmployeeId = ratingDto.EmployeeId;
            rating.ServiceRequestId = ratingDto.ServiceRequestId;
            rating.RatingValue = ratingDto.RatingValue;
            rating.RatingDate = ratingDto.RatingDate;
            rating.GivenBy = ratingDto.GivenBy;
            rating.GivenReason = ratingDto.GivenReason;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RatingExists(id))
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

      

        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RatingExists(int id)
        {
            return _context.Ratings.Any(e => e.RatingId == id);
        }
        // POST: api/RatingsExtensions/AddOrUpdate
        [HttpPost("AddOrUpdate")]
        public async Task<ActionResult<RatingAddOrUpdateResponse>> AddOrUpdateRating(RatingAddOrUpdateRequest request)
        {
            var serviceRequest = await _context.ServiceRequests
                .Include(sr => sr.Reservation)
                .FirstOrDefaultAsync(sr => sr.RequestId == request.ServiceRequestId);

            if (serviceRequest == null ||
                serviceRequest.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                serviceRequest.Status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest(new { message = "Cannot add rating for pending or cancelled service requests." });
            }

            var existingRating = await _context.Ratings
                .FirstOrDefaultAsync(r => r.ServiceRequestId == request.ServiceRequestId);

            if (existingRating != null)
            {
                // Update existing rating
                existingRating.RatingValue = request.RatingValue;
                existingRating.RatingDate = DateTime.Now;
                existingRating.GivenBy = request.IsGivenBy;
                existingRating.GivenReason = request.GivenReason;
            }
            else
            {
                // Add new rating
                var newRating = new Rating
                {
                    EmployeeId = request.EmployeeId,
                    ServiceRequestId = request.ServiceRequestId,
                    RatingValue = request.RatingValue,
                    RatingDate = DateTime.Now,
                    GivenBy = request.IsGivenBy,
                    GivenReason = request.GivenReason
                };

                _context.Ratings.Add(newRating);
            }

            await _context.SaveChangesAsync();

            return new RatingAddOrUpdateResponse
            {
                IsSuccess = true
            };
        }

        // GET: api/RatingsExtensions/GetRatingValueOrNA/5
        [HttpGet("GetRatingValueOrNA/{serviceRequestId}")]
        public async Task<ActionResult<string>> GetRatingValueOrNA(int serviceRequestId)
        {
            var rating = await _context.Ratings
                .FirstOrDefaultAsync(r => r.ServiceRequestId == serviceRequestId);

            if (rating == null)
            {
                return "N/A";
            }

            return rating.RatingValue.ToString();
        }
    }

    public class RatingAddOrUpdateRequest
    {
        public int EmployeeId { get; set; }
        public int ServiceRequestId { get; set; }
        public float RatingValue { get; set; }
        public string IsGivenBy { get; set; }
        public int GivenReason { get; set; }
    }

    public class RatingAddOrUpdateResponse
    {
        public bool IsSuccess { get; set; }
    }
}