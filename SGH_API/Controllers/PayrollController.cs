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
    [Produces("application/json")]
    [Authorize(Roles = "HR")]
    public class PayrollController : Controller
    {
        private readonly PayrollInterface _payrollInterface;
        private readonly IMapper _mapper;
        private readonly ILogger<PayrollController> _logger;
        public PayrollController(PayrollInterface payrollInterface, IMapper mapper, ILogger<PayrollController> logger)
        {
            _payrollInterface = payrollInterface;
            _mapper = mapper;
            _logger = logger;
        }
        
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(PayrollResponseDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetPayrollById(int id)
        {
            try
            {
                var payroll = await _payrollInterface.GetPayrollByIdAsync(id);
                if (payroll == null) return NotFound();

                var result = _mapper.Map<PayrollResponseDto>(payroll);
                result.EmployeeName = $"{payroll.Employee.FirstName} {payroll.Employee.LastName}";

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching payroll");
                return StatusCode(500, "Internal server error");
            }
        }

 
        [HttpGet]
        [ProducesResponseType(typeof(List<PayrollResponseDto>), 200)]
        public async Task<IActionResult> GetAllPayrolls()
        {
            var payrolls = await _payrollInterface.GetAllPayrollsAsync();
            var result = _mapper.Map<List<PayrollResponseDto>>(payrolls);

           
            foreach (var item in result.Zip(payrolls, (r, p) => new { Response = r, Payroll = p }))
            {
                item.Response.EmployeeName = $"{item.Payroll.Employee.FirstName} {item.Payroll.Employee.LastName}";
            }

            return Ok(result);
        }


        [HttpPost]
        [ProducesResponseType(typeof(PayrollResponseDto), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateOrUpdatePayroll([FromBody] PayrollCreateDto dto)
        {
            try
            {
                var payroll = _mapper.Map<Payroll>(dto);
                var createdPayroll = await _payrollInterface.CreateOrUpdatePayrollAsync(payroll);

                var result = _mapper.Map<PayrollResponseDto>(createdPayroll);
                result.EmployeeName = $"{createdPayroll.Employee.FirstName} {createdPayroll.Employee.LastName}";

                return CreatedAtAction(
                    nameof(GetPayrollById),
                    new { id = createdPayroll.PayrollId },
                    result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving payroll");
                return StatusCode(500, "Internal server error");
            }
        }


            [HttpPost("{id}/deductions")]
            [ProducesResponseType(204)]
            [ProducesResponseType(400)]
            [ProducesResponseType(404)]
            public async Task<IActionResult> AddDeduction(int id, [FromBody] DeductionRequestDto dto)
            {
                try
                {
                    await _payrollInterface.AddDeductionAsync(id, dto.Amount, dto.Reason);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error adding deduction");
                    return BadRequest(ex.Message);
                }
            }

  
        [HttpGet("{id}/payslip")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GeneratePayslip(int id)
        {
            try
            {
                var payslip = await _payrollInterface.GeneratePayslipAsync(id);
                return Ok(payslip);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating payslip");
                return NotFound(ex.Message);
            }
        }

        [HttpGet("employee/{employeeId}")]
        [ProducesResponseType(typeof(List<PayrollResponseDto>), 200)]
        public async Task<IActionResult> GetPayrollsByEmployeeId(int employeeId)
        {
            var payrolls = await _payrollInterface.GetPayrollsByEmployeeIdAsync(employeeId);
            var result = _mapper.Map<List<PayrollResponseDto>>(payrolls);

            foreach (var item in result.Zip(payrolls, (r, p) => new { Response = r, Payroll = p }))
            {
                item.Response.EmployeeName = $"{item.Payroll.Employee.FirstName} {item.Payroll.Employee.LastName}";
            }

            return Ok(result);
        }
    }
}
