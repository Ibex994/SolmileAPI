using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.ComplaintDto;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Manager,HR,Supervisor")]
    public class ComplaintsController : Controller
    {
        private readonly ComplaintInterface _complaintRepo;
        private readonly IMapper _mapper;

        public ComplaintsController(ComplaintInterface complaintRepo, IMapper mapper)
        {
            _complaintRepo = complaintRepo;
            _mapper = mapper;
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(ComplaintDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ComplaintDto>> CreateComplaint([FromQuery] int customerId, [FromBody] CreateCompDto complaintDto)
        {
            if (complaintDto == null)
                return BadRequest("Complaint data is required.");

            if (!await _complaintRepo.CustomerExists(customerId))
                return NotFound($"Customer with ID {customerId} not found.");

            var complaint = _mapper.Map<Complaint>(complaintDto);
            complaint.CustomerId = customerId;

            if (string.IsNullOrWhiteSpace(complaint.Status))
                complaint.Status = "Unresolved";

            var createdComplaint = await _complaintRepo.CreateComplaintAsync(complaint);

            if (createdComplaint == null)
                return Conflict("Complaint could not be created.");

            var resultDto = _mapper.Map<ComplaintDto>(createdComplaint);
            return CreatedAtAction(nameof(GetComplaintDetails), new { complaintId = resultDto.ComplaintId }, resultDto);
        }



        [HttpGet("Details/{complaintId}")]
        [ProducesResponseType(typeof(ComplaintDto), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ComplaintDto>> GetComplaintDetails(int complaintId)
        {
            var complaint = await _complaintRepo.GetComplaintDetailsAsync(complaintId);
            if (complaint == null)
                return NotFound();

            return Ok(_mapper.Map<ComplaintDto>(complaint));
        }

        [HttpGet("History/{customerId}")]
        [ProducesResponseType(typeof(List<ComplaintDto>), 200)]
        public async Task<ActionResult<List<ComplaintDto>>> GetComplaintHistory(int customerId)
        {
            var history = await _complaintRepo.GetComplaintHistoryAsync(customerId);
            return Ok(_mapper.Map<List<ComplaintDto>>(history));
        }


        [HttpGet("TrackStatus/{complaintId}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<string>> TrackComplaintStatus(int complaintId)
        {
            var status = await _complaintRepo.TrackComplaintStatusAsync(complaintId);
            if (status == "Not Found")
                return NotFound();
            return Ok(status);
        }

        [HttpPut("UpdateStatus/{complaintId}")]
        public async Task<IActionResult> UpdateComplaintStatus(int complaintId, [FromBody] UpdateCompDto updateDto)
        {
            var status = updateDto.status;

            var result = await _complaintRepo.UpdateComplaintStatusAsync(complaintId, status);
            if (!result)
                return NotFound();

            return NoContent();
        }

        [HttpPut("Resolve/{complaintId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResolveComplaint(int complaintId)
        {
            var result = await _complaintRepo.ResolveComplaintAsync(complaintId);
            if (!result)
                return NotFound();

            return NoContent(); 
        }


        [HttpPut("AssignHandler")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AssignComplaintHandler([FromQuery] int complaintId, [FromQuery] int employeeId)
        {
            var result = await _complaintRepo.AssignComplaintHandlerAsync(employeeId, complaintId);
            if (!result)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("Delete/{complaintId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteComplaint(int complaintId)
        {
            var result = await _complaintRepo.DeleteComplaintAsync(complaintId);
            if (!result)
                return NotFound();
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ComplaintDto>), 200)]
        public async Task<ActionResult<List<ComplaintDto>>> ViewComplaints()
        {
            var complaints = await _complaintRepo.ViewComplaintsAsync();
            return Ok(_mapper.Map<List<ComplaintDto>>(complaints));
        }
    }
}
