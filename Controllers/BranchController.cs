using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Enum;
using SolmileAPI.Interface;
using SolmileAPI.Repository;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : Controller
    {
        private readonly BranchInterface _branchInterface;
        private readonly IMapper _mapper;

        public BranchController(BranchInterface branchInterface, IMapper mapper)
        {
            _branchInterface = branchInterface;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddBranch([FromBody] CreateBranchDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var branch = _mapper.Map<Branch>(dto);

            bool result = await _branchInterface.AddBranchAsync(branch.Location, branch.Name);

            if (result)
            {
                return Ok("Branch added successfully.");
            }

            return BadRequest("Failed to add branch.");
        }

        [HttpPut("{branchId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateBranch(int branchId, [FromBody] UpdateBranchDto dto)
        {
            var updatedBranch = _mapper.Map<Branch>(dto);
            updatedBranch.BranchId = branchId;

            bool result = await _branchInterface.UpdateBranchAsync(branchId, updatedBranch);

            if (result)
            {
                return Ok("Branch updated successfully.");
            }

            return NotFound("Branch not found.");
        }

        [HttpDelete("{branchId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteBranch(int branchId)
        {
            bool result = await _branchInterface.DeleteBranchAsync(branchId);

            if (result)
            {
                return Ok("Branch deleted successfully.");
            }

            return NotFound("Branch not found.");
        }

        [HttpGet("{branchId}")]
        [ProducesResponseType(typeof(BranchDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetBranch(int branchId)
        {
            var branch = await _branchInterface.ViewBranchDetailsAsync(branchId);

            if (branch == null)
            {
                return NotFound("Branch not found.");
            }

            var dto = _mapper.Map<BranchDto>(branch);
            return Ok(dto);
        }

        [HttpPatch("{branchId}/assign-contact/{contactId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AssignContact(int branchId, int contactId)
        {
            var result = await _branchInterface.AssignContactDetailsAsync(branchId, contactId);

            return result switch
            {
                AssignContactResults.Success => Ok("Contact assigned successfully."),
                AssignContactResults.BranchNotFound => NotFound("Branch not found."),
                AssignContactResults.ContactNotFound => NotFound("Contact not found."),
                AssignContactResults.BranchAlreadyAssigned => BadRequest("Branch already has a contact assigned."),
                AssignContactResults.ContactAlreadyAssigned => BadRequest("Contact is already assigned to a branch."),
                _ => StatusCode(500, "Unexpected error.")
            };
        }

        [HttpPatch("unassign-contact/{contactId}/{branchId}")]
        public async Task<IActionResult> UnassignContactFromBranch(int contactId, int branchId)
        {
            var result = await _branchInterface.UnassignContactFromBranchAsync(contactId, branchId);

            return result switch
            {
                UnassignContactResult.Success => Ok("Contact successfully unassigned from branch."),
                UnassignContactResult.ContactNotFound => NotFound("Contact not found."),
                UnassignContactResult.ContactAlreadyUnassigned => BadRequest("Contact is already unassigned from this branch."),
                UnassignContactResult.BranchNotFound => NotFound("Branch not found."),
                UnassignContactResult.BranchContactMismatch => BadRequest("The contact is not assigned to the given branch."),
                UnassignContactResult.DatabaseError => StatusCode(500, "An error occurred while processing the request."),
                _ => StatusCode(500, "Unexpected error occurred.")
            };
        }





    }
}

