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
        //[Authorize(Roles = "HR")]
    public class TaxController : Controller
        {
            private readonly TaxInterface _taxInterface;
            private readonly IMapper _mapper;

            public TaxController(TaxInterface taxInterface, IMapper mapper)
            {
                _taxInterface = taxInterface;
                _mapper = mapper;
            }

            [HttpGet("{id}")]
            [ProducesResponseType(typeof(TaxDto), 200)]
            [ProducesResponseType(404)]
            public async Task<IActionResult> GetTaxById(int id)
            {
                var tax = await _taxInterface.GetTaxByIdAsync(id);
                if (tax == null) return NotFound();

                return Ok(_mapper.Map<TaxDto>(tax));
            }

            [HttpGet]
            [ProducesResponseType(typeof(IEnumerable<TaxDto>), 200)]
            public async Task<IActionResult> GetAllTaxes()
            {
                var taxes = await _taxInterface.GetAllTaxesAsync();
                return Ok(_mapper.Map<IEnumerable<TaxDto>>(taxes));
            }

            [HttpPost]
            [ProducesResponseType(typeof(TaxDto), 201)]
            [ProducesResponseType(400)]
            public async Task<IActionResult> CreateTax([FromBody] CreateTaxDto dto)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var tax = _mapper.Map<Tax>(dto);
                tax.TaxAmount = 0;

                var created = await _taxInterface.CreateTaxAsync(tax);
                return CreatedAtAction(nameof(GetTaxById), new { id = created.TaxId }, _mapper.Map<TaxDto>(created));
            }

            [HttpPut("{id}")]
            [ProducesResponseType(typeof(TaxDto), 200)]
            [ProducesResponseType(400)]
            [ProducesResponseType(404)]
            public async Task<IActionResult> UpdateTax(int id, [FromBody] UpdateTaxDto dto)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var updatedModel = _mapper.Map<Tax>(dto);
                var updated = await _taxInterface.UpdateTaxAsync(id, updatedModel);

                if (updated == null) return NotFound();

                return Ok(_mapper.Map<TaxDto>(updated));
            }

            [HttpDelete("{id}")]
            [ProducesResponseType(204)]
            [ProducesResponseType(404)]
            public async Task<IActionResult> DeleteTax(int id)
            {
                var deleted = await _taxInterface.DeleteTaxAsync(id);
                return deleted ? NoContent() : NotFound();
            }

            [HttpGet("calculate/{taxId}/{salary}")]
            [ProducesResponseType(typeof(TaxResultDto), 200)]
            [ProducesResponseType(404)]
            public async Task<IActionResult> CalculateTax(int taxId, float salary)
            {
                var result = await _taxInterface.CalculateTaxAsync(taxId, salary);
                if (result == null) return NotFound();
                return Ok(result);
            }


        [HttpGet("details/{employeeId}")]
            [ProducesResponseType(typeof(string), 200)]
            public async Task<IActionResult> ViewTaxDetails(int employeeId)
            {
                var details = await _taxInterface.ViewTaxDetailsAsync(employeeId);
                return Ok(details);
            }
        }
    }
