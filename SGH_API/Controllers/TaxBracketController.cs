using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

[ApiController]
[Route("api/[controller]")]
public class TaxBracketController : ControllerBase
{
    private readonly TaxBracketInterface _taxBracketInterface;
    private readonly IMapper _mapper;

    public TaxBracketController(TaxBracketInterface taxBracketInterface, IMapper mapper)
    {
        _taxBracketInterface = taxBracketInterface;
        _mapper = mapper;
    }

    [HttpPost("create")]
    [ProducesResponseType(typeof(TaxBracket), 201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateTaxBracket([FromBody] CreateTaxBracketDto dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var bracket = _mapper.Map<TaxBracket>(dto);
        var result = await _taxBracketInterface.CreateTaxBracketAsync(bracket);
        return CreatedAtAction(nameof(GetTaxBracketById), new { id = result.Id }, result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TaxBracket), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetTaxBracketById(int id)
    {
        var bracket = await _taxBracketInterface.GetTaxBracketByIdAsync(id);
        if (bracket == null) return NotFound();
        return Ok(bracket);
    }

    [HttpPost("calculate")]
    [ProducesResponseType(typeof(TaxResultDto), 200)]
    public async Task<IActionResult> CalculateTax([FromBody] GrossSalaryDto dto)
    {
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

        var result = new TaxResultDto
        {
            GrossSalary = dto.GrossSalary,
            TaxRateApplied = bracket.RatePercent,
            Deductible = bracket.Deductible,
            TaxAmount = Math.Round(taxAmount, 2),
            NetSalary = Math.Round(dto.GrossSalary - taxAmount, 2)
        };

        return Ok(result);
    }
}
