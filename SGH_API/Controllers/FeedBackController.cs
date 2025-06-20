using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Manager")]
    public class FeedBackController : Controller
    {
        private readonly FeedBackInterface _feedBackInterface;
        private readonly IMapper _mapper;

        public FeedBackController(FeedBackInterface feedBackInterface, IMapper mapper)
        {
            _feedBackInterface = feedBackInterface;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<FeedbackDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FeedbackDto>>> GetAllFeedbacks()
        {
            var feedbacks = await _feedBackInterface.GetAllFeedbacksAsync();

            if (feedbacks == null || !feedbacks.Any())
                return NotFound("No feedback records found.");

            var result = _mapper.Map<List<FeedbackDto>>(feedbacks);
            return Ok(result);
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateFeedback([FromBody] CreateFeedbackDto feedbackDto)
        {
            if (feedbackDto == null)
                return BadRequest("Feedback data is required.");
            var feedback = _mapper.Map<FeedBack>(feedbackDto);
            var (success, message) = await _feedBackInterface.CreateFeedbackAsync(feedback);
            if (success)
                return Ok(message);
            else
                return StatusCode(500, message);
        }


        [HttpGet("customer/{customerId}")]
        [ProducesResponseType(typeof(List<FeedbackDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<FeedbackDto>>> GetFeedbacksByCustomerId(int customerId)
        {
            var feedbacks = await _feedBackInterface.GetFeedbacksByCustomerIdAsync(customerId);

            if (feedbacks == null || !feedbacks.Any())
                return NotFound("No feedback found for the specified customer.");

            var result = _mapper.Map<List<FeedbackDto>>(feedbacks);
            return Ok(result);
        }

        [HttpGet("{feedbackId}")]
        [ProducesResponseType(typeof(FeedbackDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FeedbackDto>> GetFeedbackById(int feedbackId)
        {
            var feedback = await _feedBackInterface.GetFeedbackByIdAsync(feedbackId);

            if (feedback == null)
                return NotFound("Feedback not found.");

            var result = _mapper.Map<FeedbackDto>(feedback);
            return Ok(result);
        }

        [HttpPut("{feedbackId}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateFeedback(int feedbackId, [FromBody] CreateFeedbackDto feedbackDto)
        {
            if (feedbackDto == null)
                return BadRequest("Updated feedback data is required.");

            var existingFeedback = await _feedBackInterface.GetFeedbackByIdAsync(feedbackId);
            if (existingFeedback == null)
                return NotFound("Feedback not found.");

            var updatedFeedback = _mapper.Map<FeedBack>(feedbackDto);
            updatedFeedback.FeedbackId = feedbackId;

            var success = await _feedBackInterface.UpdateFeedbackAsync(updatedFeedback);

            return success
                ? Ok("Feedback updated successfully.")
                : StatusCode(500, "Failed to update feedback.");
        }

        [HttpDelete("{feedbackId}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteFeedback(int feedbackId)
        {
            var success = await _feedBackInterface.DeleteFeedbackAsync(feedbackId);

            return success
                ? Ok("Feedback deleted successfully.")
                : NotFound("Feedback not found or already deleted.");
        }
    }
}
