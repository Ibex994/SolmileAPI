using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;
using TaxDto = SolmileGuesthouseAPI.DTO.NavigatorModel.TaxDto;

namespace SolmileGuesthouseAPI.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        //[Authorize(Roles = "HR")]
    public class TaxController : Controller
        {
            private readonly TaxInterface _taxInterface;
            private readonly IMapper _mapper;
        private readonly TaxBracketInterface _taxBracketInterface;

        public TaxController(TaxInterface taxInterface, IMapper mapper,TaxBracketInterface taxBracketInterface)
            {
                _taxInterface = taxInterface;
                _mapper = mapper;
                _taxBracketInterface = taxBracketInterface;
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

            if (dto.GrossSalary <= 0)
                return BadRequest("Gross salary must be greater than 0.");

            var brackets = await _taxBracketInterface.GetAllTaxBracketsAsync();

            var bracket = brackets
                .OrderBy(b => b.From)
                .FirstOrDefault(b => dto.GrossSalary >= b.From && dto.GrossSalary <= b.To);

            if (bracket == null)
                return NotFound("No applicable tax bracket found.");

            var taxAmount = ((dto.GrossSalary * bracket.RatePercent) / 100) - bracket.Deductible;
            if (taxAmount < 0) taxAmount = 0;
            var tax = new Tax
            {
                EmployeeId = dto.EmployeeId,
                GrossSalary = dto.GrossSalary,        
                TaxRate = bracket.RatePercent,
                TaxAmount = Math.Round(taxAmount, 2),
                Deduction = bracket.Deductible        
            };

            var created = await _taxInterface.CreateTaxAsync(tax);

            var resultDto = _mapper.Map<TaxDto>(created);
            return CreatedAtAction(nameof(GetTaxById), new { id = resultDto.TaxId }, resultDto);
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
                var result = await _taxInterface.CalculateTaxAsync(salary);
                if (result == null) return NotFound();
                return Ok(result);
            }

        [HttpGet("employee/{employeeId}")]
        [ProducesResponseType(typeof(IEnumerable<TaxDto>), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetTaxesByEmployeeId(int employeeId)
        {
            var taxes = await _taxInterface.GetTaxesByEmployeeIdAsync(employeeId);
            if (taxes == null || !taxes.Any())
                return NotFound($"No tax records found for Employee ID: {employeeId}");

            return Ok(_mapper.Map<IEnumerable<TaxDto>>(taxes));
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
