using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "HR")]
    public class PayrollController : Controller
    {
        private readonly PayrollInterface _payrollInterface;
        private readonly IMapper _mapper;
        private readonly ILogger<PayrollController> _logger;
        private readonly TaxInterface _taxInterface;

        public PayrollController(PayrollInterface payrollInterface, IMapper mapper, ILogger<PayrollController> logger,
            TaxInterface taxInterface)
        {
            _payrollInterface = payrollInterface;
            _mapper = mapper;
            _logger = logger;
            _taxInterface = taxInterface;
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

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(PayrollResponseDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdatePayroll(int id, [FromBody] PayrollCreateDto dto)
        {
            try
            {
                var existingPayroll = await _payrollInterface.GetPayrollByIdAsync(id);
                if (existingPayroll == null)
                    return NotFound("Payroll record not found.");

                var payroll = _mapper.Map<Payroll>(dto);
                payroll.PayrollId = id;

                // Auto-calculate tax again
                var taxResult = await _taxInterface.CalculateTaxAsync((float)payroll.BasicSalary);
                if (taxResult == null)
                    return BadRequest("No applicable tax bracket found.");

                payroll.Tax = payroll.BasicSalary * 0.15m;
                payroll.NetSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions - payroll.Tax;

                await _payrollInterface.CreateOrUpdatePayrollAsync(payroll);

                var updatedPayroll = await _payrollInterface.GetPayrollByIdAsync(id);
                var result = _mapper.Map<PayrollResponseDto>(updatedPayroll);
                result.EmployeeName = $"{updatedPayroll.Employee?.FirstName} {updatedPayroll.Employee?.LastName}";

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating payroll");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeletePayroll(int id)
        {
            try
            {
                var payroll = await _payrollInterface.GetPayrollByIdAsync(id);
                if (payroll == null)
                    return NotFound("Payroll not found.");

                await _payrollInterface.DeletePayrollAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting payroll");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPost]
        [ProducesResponseType(typeof(PayrollResponseDto), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateOrUpdatePayroll([FromBody] PayrollCreateDto dto)
        {
            try
            {
                var payroll = _mapper.Map<Payroll>(dto);
                var taxResult = await _taxInterface.CalculateTaxAsync((float)payroll.BasicSalary);

                if (taxResult == null)
                {
                    _logger.LogWarning("No applicable tax bracket found for BasicSalary {BasicSalary}", payroll.BasicSalary);
                    return BadRequest("No applicable tax bracket found for the given basic salary.");
                }

                payroll.Tax = payroll.BasicSalary * 0.15m; 

                payroll.NetSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions - payroll.Tax;


                var createdPayroll = await _payrollInterface.CreateOrUpdatePayrollAsync(payroll);

                var updatedPayroll = await _payrollInterface.GetPayrollByIdAsync(createdPayroll.PayrollId);

                var result = _mapper.Map<PayrollResponseDto>(updatedPayroll);

                result.EmployeeName = updatedPayroll.Employee != null
                    ? $"{updatedPayroll.Employee.FirstName} {updatedPayroll.Employee.LastName}"
                    : "Unknown Employee";

                return CreatedAtAction(
                    nameof(GetPayrollById),
                    new { id = updatedPayroll.PayrollId },
                    result);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Bad request while saving payroll");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving payroll");
                return StatusCode(500, $"Internal server error: {ex.Message}");
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


        [HttpGet("payslip/{EmployeeId}")]
        public async Task<IActionResult> GetPayslipPdf(int EmployeeId)
        {
            try
            {
                var pdfBytes = await _payrollInterface.GeneratePayslipPdfAsync(EmployeeId);
                return File(pdfBytes, "application/pdf", $"Payslip_{EmployeeId}.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error generating payslip: {ex.Message}");
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
            try
            {
                var pdfBytes = await _payrollInterface.GeneratePayslipPdfAsync(employeeId);
                return File(pdfBytes, "application/pdf", $"Payslip_{employeeId}.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error generating payslip: {ex.Message}");
            }
        }
        [HttpGet("download-pdf-by-date")]
        public async Task<IActionResult> DownloadPayrollsByDate([FromQuery] DateTime payPeriod)
        {
            try
            {
                var pdfBytes = await _payrollInterface.GeneratePayrollPdfByDateAsync(payPeriod);

                if (pdfBytes == null)
                    return NotFound("No payroll records found for the specified pay period.");

                return File(pdfBytes, "application/pdf", $"Payrolls_{payPeriod:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating payroll PDF");
                return StatusCode(500, $"Internal server error generating PDF: {ex.Message}");
            }

        }
    }
}
