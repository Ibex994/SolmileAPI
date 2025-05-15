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
    public class BranchesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public BranchesController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/Branches
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

        // GET: api/Branches/5
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

        // PUT: api/Branches/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, UInsertionBranchDto branchDto)
        {
            //if (id != branchDto.BranchId)
            //{
            //    return BadRequest();
            //}

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

        // POST: api/Branches
        [HttpPost]
        public async Task<ActionResult<BranchDto>> PostBranch(UInsertionBranchDto branchDto)
        {
            //var contactdetails = new contactdetails
            //{
            //    phone = branchdto.contactdetails.phone,
            //    email = branchdto.contactdetails.email,
            //    address = branchdto.contactdetails.address,
            //    emergencycontact = branchdto.contactdetails.emergencycontact
            //};

            // _context.ContactDetails.Add(contactDetails);
            //  await _context.SaveChangesAsync();

            var branch = new Branch
            {
                Location = branchDto.Location,
                Name = branchDto.Name,
                ContactId = branchDto.ContactId,
                // ContactDetails = contactDetails
            };

            _context.Branches.Add(branch);
            await _context.SaveChangesAsync();

            branchDto.BranchId = branch.BranchId;
            //  branchDto.ContactId = contactDetails.ContactId;
            // return CreatedAtAction("findBranchById", new { id = branch.BranchId }, branchDto);

            return new BranchDto
            {
                BranchId = branch.BranchId,
                Location = branch.Location,
                Name = branch.Name,
                ContactId = branch.ContactId};
            }

        // DELETE: api/Branches/5
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

        private bool BranchExists(int id)
        {
            return _context.Branches.Any(e => e.BranchId == id);
        }
    }

}
