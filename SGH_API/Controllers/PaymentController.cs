using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Manager,Reception")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentInterface _paymentInterface;
        private readonly IMapper _mapper;

        public PaymentController(PaymentInterface paymentInterface, IMapper mapper)
        {
            _paymentInterface = paymentInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PaymentDto>), 200)]
        public async Task<IActionResult> GetAllPayments()
        {
            var payments = await _paymentInterface.GetAllPaymentsAsync();
            return Ok(_mapper.Map<IEnumerable<PaymentDto>>(payments));
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(PaymentDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetPaymentById(int id)
        {
            var payment = await _paymentInterface.GetPaymentByIdAsync(id);
            if (payment == null)
                return NotFound(new { Message = $"Payment with ID {id} not found." });

            return Ok(_mapper.Map<PaymentDto>(payment));
        }

        [HttpPost]
        [ProducesResponseType(typeof(PaymentDto), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreatePayment([FromBody] CreatePaymentDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var payment = _mapper.Map<Payment>(dto);
            var created = await _paymentInterface.CreatePaymentAsync(payment);
            return CreatedAtAction(nameof(GetPaymentById), new { id = created.PaymentId }, _mapper.Map<PaymentDto>(created));
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(PaymentDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdatePayment(int id, [FromBody] UpdatePaymentDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedEntity = _mapper.Map<Payment>(dto);
            var updated = await _paymentInterface.UpdatePaymentAsync(id, updatedEntity);

            if (updated == null)
                return NotFound(new { Message = $"Payment with ID {id} not found." });

            return Ok(_mapper.Map<PaymentDto>(updated));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeletePayment(int id)
        {
            var deleted = await _paymentInterface.DeletePaymentAsync(id);
            return deleted ? NoContent() : NotFound(new { Message = $"Payment with ID {id} not found." });
        }

        [HttpPost("process")]
        [ProducesResponseType(typeof(PaymentResultDto), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> ProcessPayment([FromBody] ProcessPaymentDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _paymentInterface.ProcessPaymentAsync(dto.ReservationId, dto.Amount, dto.MethodId);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
