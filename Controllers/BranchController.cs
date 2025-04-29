using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.Models;
using SolmileAPI.DTO;
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
        public async Task<IActionResult> AddBranch([FromBody] BranchDto dto)
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
        public async Task<IActionResult> UpdateBranch(int branchId, [FromBody] BranchDto dto)
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
        [ProducesResponseType(404)]
        public async Task<IActionResult> AssignContact(int branchId, int contactId)
        {
            bool result = await _branchInterface.AssignContactDetailsAsync(branchId, contactId);

            if (result)
            {
                return Ok("Contact assigned successfully.");
            }

            return NotFound("Branch not found.");
        }
    }
}
