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
    public class BranchesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public BranchesController(GuesthouseDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BranchDto>>> GetBranches()
        {
            return await _context.Branches
                .Include(b => b.ContactDetails)
                .Select(b => new BranchDto
                {
                    BranchId = b.BranchId,
                    Location = b.Location,
                    Name = b.Name,
                    ContactId = b.ContactId,
                    ContactDetails = new ContactDetailsDto
                    {
                        ContactId = b.ContactDetails.ContactId,
                        Phone = b.ContactDetails.Phone,
                        Email = b.ContactDetails.Email,
                        Address = b.ContactDetails.Address,
                        EmergencyContact = b.ContactDetails.EmergencyContact
                    }
                })
                .ToListAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<BranchDto>> findBranchById(int id)
        {
            var branch = await _context.Branches
                .Include(b => b.ContactDetails)
                .FirstOrDefaultAsync(b => b.BranchId == id);

            if (branch == null)
            {
                return NotFound();
            }

            return new BranchDto
            {
                BranchId = branch.BranchId,
                Location = branch.Location,
                Name = branch.Name,
                ContactId = branch.ContactId,
                ContactDetails = new ContactDetailsDto
                {
                    ContactId = branch.ContactDetails.ContactId,
                    Phone = branch.ContactDetails.Phone,
                    Email = branch.ContactDetails.Email,
                    Address = branch.ContactDetails.Address,
                    EmergencyContact = branch.ContactDetails.EmergencyContact
                }
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, UInsertionBranchDto branchDto)
        {

            var branch = await _context.Branches
                .Include(b => b.ContactDetails)
                .FirstOrDefaultAsync(b => b.BranchId == id);

            if (branch == null)
            {
                return NotFound();
            }

            branch.Location = branchDto.Location;
            branch.Name = branchDto.Name;
            branch.ContactId = branchDto.ContactId;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchExists(id))
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
        public async Task<ActionResult<BranchDto>> PostBranch(UInsertionBranchDto branchDto)
        {
            var branch = new Branch
            {
                Location = branchDto.Location,
                Name = branchDto.Name,
                ContactId = branchDto.ContactId,
            };

            _context.Branches.Add(branch);
            await _context.SaveChangesAsync();

            branchDto.BranchId = branch.BranchId;

            return new BranchDto
            {
                BranchId = branch.BranchId,
                Location = branch.Location,
                Name = branch.Name,
                ContactId = branch.ContactId};
            }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            var branch = await _context.Branches
                .Include(b => b.ContactDetails)
                .FirstOrDefaultAsync(b => b.BranchId == id);

            if (branch == null)
            {
                return NotFound();
            }

            _context.Branches.Remove(branch);
            _context.ContactDetails.Remove(branch.ContactDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpGet("find-by-location/{location}")]
        public async Task<ActionResult<IEnumerable<BranchDto>>> FindBranchesByLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return BadRequest("Location is required.");

            location = location.Trim().ToLower();

            var branches = await _context.Branches
                .Include(b => b.ContactDetails)
                .Where(b => b.Location.ToLower().Contains(location))
                .Select(b => new BranchDto
                {
                    BranchId = b.BranchId,
                    Location = b.Location,
                    Name = b.Name,
                    ContactId = b.ContactId,
                    ContactDetails = new ContactDetailsDto
                    {
                        ContactId = b.ContactDetails.ContactId,
                        Phone = b.ContactDetails.Phone,
                        Email = b.ContactDetails.Email,
                        Address = b.ContactDetails.Address,
                        EmergencyContact = b.ContactDetails.EmergencyContact
                    }
                })
                .ToListAsync();

            if (!branches.Any())
                return NotFound("No branches found for the given location.");

            return Ok(branches);
        }

        private bool BranchExists(int id)
        {
            return _context.Branches.Any(e => e.BranchId == id);
        }
    }

}
