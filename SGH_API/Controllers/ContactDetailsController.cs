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
    public class ContactDetailsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public ContactDetailsController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/ContactDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDetailsDto>>> GetContactDetails()
        {
            return await _context.ContactDetails
                .Select(c => new ContactDetailsDto
                {
                    ContactId = c.ContactId,
                    Phone = c.Phone,
                    Email = c.Email,
                    Address = c.Address,
                    EmergencyContact = c.EmergencyContact
                })
                .ToListAsync();
        }

        // GET: api/ContactDetails/5
        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<ContactDetailsDto>> findContactDetailsById(int id)
        {
            var contactDetails = await _context.ContactDetails.FindAsync(id);

            if (contactDetails == null)
            {
                return NotFound();
            }

            return new ContactDetailsDto
            {
                ContactId = contactDetails.ContactId,
                Phone = contactDetails.Phone,
                Email = contactDetails.Email,
                Address = contactDetails.Address,
                EmergencyContact = contactDetails.EmergencyContact
            };
        }

        // PUT: api/ContactDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactDetails(int id, UInsertionContactDetailsDto contactDetailsDto)
        {
           // if (id != contactDetailsDto.ContactId)
          //  {
            //    return BadRequest();
          //  }

            var contactDetails = await _context.ContactDetails.FindAsync(id);
            if (contactDetails == null)
            {
                return NotFound();
            }

            contactDetails.Phone = contactDetailsDto.Phone;
            contactDetails.Email = contactDetailsDto.Email;
            contactDetails.Address = contactDetailsDto.Address;
            contactDetails.EmergencyContact = contactDetailsDto.EmergencyContact;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactDetailsExists(id))
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

        // POST: api/ContactDetails
        [HttpPost]
        public async Task<ActionResult<ContactDetailsDto>> PostContactDetails(UInsertionContactDetailsDto contactDetailsDto)
        {
            var contactDetails = new ContactDetails
            {
                Phone = contactDetailsDto.Phone,
                Email = contactDetailsDto.Email,
                Address = contactDetailsDto.Address,
                EmergencyContact = contactDetailsDto.EmergencyContact
            };

            _context.ContactDetails.Add(contactDetails);
            await _context.SaveChangesAsync();

            contactDetailsDto.ContactId = contactDetails.ContactId;
            return new ContactDetailsDto
            {
                ContactId = contactDetails.ContactId,
                Phone = contactDetails.Phone,
                Email = contactDetails.Email,
                Address = contactDetails.Address,
                EmergencyContact = contactDetails.EmergencyContact
            };
        }

        // DELETE: api/ContactDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactDetails(int id)
        {
            var contactDetails = await _context.ContactDetails.FindAsync(id);
            if (contactDetails == null)
            {
                return NotFound();
            }

            _context.ContactDetails.Remove(contactDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactDetailsExists(int id)
        {
            return _context.ContactDetails.Any(e => e.ContactId == id);
        }
    }

}
