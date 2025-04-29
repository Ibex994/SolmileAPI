using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolmileAPI.DTO;
using SolmileAPI.Interface;
using SolmileAPI.Models;
using SolmileAPI.Repository;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDeatilController : Controller
    {
        private readonly BranchInterface _branchInterface;
        private readonly ContactDetailInterface _contactDetailInterface;
        private readonly IMapper _mapper;

        public ContactDeatilController(BranchInterface branchInterface, ContactDetailInterface contactDetailInterface, IMapper mapper)
        {
            _branchInterface = branchInterface;
            _contactDetailInterface = contactDetailInterface;
            _mapper = mapper;
        }

        [HttpPut("{branchId}/update-contact")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateContactDetails(int branchId, [FromBody] ContactDetailDto updatedDetailsDto)
        {
            var updatedDetails = _mapper.Map<ContactDetail>(updatedDetailsDto);

            var result = await _contactDetailInterface.UpdateContactDetailsAsync(branchId, updatedDetails);
            if (result)
                return Ok("Contact details updated successfully.");
            return BadRequest("Failed to update contact details.");
        }

        [HttpGet("{contactId}")]
        [ProducesResponseType(typeof(ContactDetailDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetContactDetails(int contactId)
        {
            var contact = await _contactDetailInterface.GetContactDetailsAsync(contactId);
            if (contact == null)
                return NotFound("Contact not found.");

            var contactDto = _mapper.Map<ContactDetailDto>(contact);
            return Ok(contactDto);
        }

        [HttpPatch("assign-contact/{contactId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AssignBranchToContact(int contactId, [FromBody] AssignBranchDto dto)
        {
            var branchId = dto.BranchId;

            var result = await _contactDetailInterface.AssignBranchToContactAsync(contactId, branchId);
            if (result)
            {
                return Ok("Branch assigned to contact successfully.");
            }
            return BadRequest("Failed to assign branch to contact.");
        }


        [HttpPost("create-contact")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateContactDetails([FromBody] CreateConDetDto newDetailsDto)
        {
            var newDetails = _mapper.Map<ContactDetail>(newDetailsDto);

            var result = await _contactDetailInterface.CreateContactDetailsAsync(newDetails);
            if (result)
            {
                return Ok("Contact details created successfully.");
            }
            return BadRequest("Failed to create contact details.");
        }

        [HttpDelete("{contactId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteContactDetails(int contactId)
        {
            var result = await _contactDetailInterface.DeleteContactDetailsAsync(contactId);
            if (result)
                return Ok("Contact details deleted successfully.");
            return NotFound("Contact not found.");
        }

        [HttpPost("validate-contact")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult ValidateContactDetails([FromBody] ContactDetailDto detailsDto)
        {
            var details = _mapper.Map<ContactDetail>(detailsDto);

            var isValid = _contactDetailInterface.ValidateContactDetails(details);
            return isValid ? Ok("Contact details are valid.") : BadRequest("Invalid contact details.");
        }
    }
}
