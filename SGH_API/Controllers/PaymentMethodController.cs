using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly PaymentMethodInterface _paymentMethodInterface;
        private readonly IMapper _mapper;

        public PaymentMethodController(PaymentMethodInterface paymentMethodInterface, IMapper mapper)
        {
            _paymentMethodInterface = paymentMethodInterface;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PaymentMethodDto>), 200)]
        public async Task<IActionResult> GetAll()
        {
            var methods = await _paymentMethodInterface.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PaymentMethodDto>>(methods));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PaymentMethodDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(int id)
        {
            var method = await _paymentMethodInterface.GetByIdAsync(id);
            if (method == null) return NotFound();

            return Ok(_mapper.Map<PaymentMethodDto>(method));
        }

        [HttpPost]
        [ProducesResponseType(typeof(PaymentMethodDto), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Add([FromBody] CreatePaymentMethodDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var method = _mapper.Map<PaymentMethod>(dto);
            var created = await _paymentMethodInterface.AddAsync(method);

            return CreatedAtAction(nameof(GetById), new { id = created.MethodId }, _mapper.Map<PaymentMethodDto>(created));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(PaymentMethodDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePaymentMethodDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var updatedModel = _mapper.Map<PaymentMethod>(dto);
            var updated = await _paymentMethodInterface.UpdateAsync(id, updatedModel);
            if (updated == null) return NotFound();

            return Ok(_mapper.Map<PaymentMethodDto>(updated));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _paymentMethodInterface.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }
    }
}
