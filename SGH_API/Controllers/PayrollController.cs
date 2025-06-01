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
    [Produces("application/json")]
    //[Authorize(Roles = "HR")]
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

                await _payrollInterface.CalculateNetSalaryAsync(createdPayroll.PayrollId);

                var updatedPayroll = await _payrollInterface.GetPayrollByIdAsync(createdPayroll.PayrollId);

                var result = _mapper.Map<PayrollResponseDto>(updatedPayroll);
                if (updatedPayroll.Employee != null)
                {
                    result.EmployeeName = $"{updatedPayroll.Employee.FirstName} {updatedPayroll.Employee.LastName}";
                }
                else
                {
                    result.EmployeeName = "Unknown Employee";
                    _logger.LogWarning("Employee info was null for Payroll ID {PayrollId}", updatedPayroll.PayrollId);
                }

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
                var payrolls = await _payrollInterface.GetPayrollsByDateAsync(payPeriod);

                if (!payrolls.Any())
                    return NotFound("No payroll records found for the specified pay period.");

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(30);
                        page.DefaultTextStyle(x => x.FontSize(12));
                        page.Content().Column(col =>
                        {
                            col.Spacing(25);

                            col.Item().Text($"Payroll Report – {payPeriod:MMMM dd, yyyy}")
                                .Bold().FontSize(18).AlignCenter();

                            foreach (var payroll in payrolls)
                            {
                                var employeeName = $"{payroll.Employee?.FirstName} {payroll.Employee?.LastName}";
                                var netSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions;

                                col.Item().Border(1).Padding(10).Column(item =>
                                {
                                    item.Spacing(5);

                                    item.Item().Text($"👤 Employee: {employeeName}").Bold();
                                    item.Item().Text($"📅 Pay Period: {payroll.PayPeriod:yyyy-MM-dd}");

                                    item.Item().Table(table =>
                                    {
                                        table.ColumnsDefinition(c =>
                                        {
                                            c.ConstantColumn(150);
                                            c.RelativeColumn();
                                        });

                                        table.Cell().Element(CellStyle).Text("Basic Salary:");
                                        table.Cell().Element(CellStyle).Text($"{payroll.BasicSalary:N2} ETB");

                                        table.Cell().Element(CellStyle).Text("Allowances:");
                                        table.Cell().Element(CellStyle).Text($"{payroll.Allowances:N2} ETB");

                                        table.Cell().Element(CellStyle).Text("Deductions:");
                                        table.Cell().Element(CellStyle).Text($"{payroll.Deductions:N2} ETB");

                                        if (!string.IsNullOrWhiteSpace(payroll.DeductionReason))
                                        {
                                            table.Cell().Element(CellStyle).Text("Deduction Reason:");
                                            table.Cell().Element(CellStyle).Text(payroll.DeductionReason);
                                        }

                                        table.Cell().Element(CellStyle).Text("Net Salary:").Bold();
                                        table.Cell().Element(CellStyle).Text($"{netSalary:N2} ETB").Bold();
                                    });

                                    item.Item().PaddingTop(10).Text("Signature: ____________________________");
                                });
                            }
                        });
                    });
                });

                using var stream = new MemoryStream();
                document.GeneratePdf(stream);
                var pdfBytes = stream.ToArray();

                return File(pdfBytes, "application/pdf", $"Payrolls_{payPeriod:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating payroll PDF");
                return StatusCode(500, "Internal server error generating PDF.");
            }

            static IContainer CellStyle(IContainer container) => container.PaddingVertical(2);
        }
    } 
}
