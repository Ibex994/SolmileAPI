using System.Globalization;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;
using QuestPDF;


using Task = System.Threading.Tasks.Task;
using QuestPDF.Infrastructure;
namespace SolmileGuesthouseAPI.Repository
{
    public class PayrollRepo : PayrollInterface
    {
        private readonly GuesthouseDbContext _context;

        public PayrollRepo(GuesthouseDbContext context)
        {
            _context = context;
        }
        // CRUD
        public async Task<Payroll> GetPayrollByIdAsync(int payrollId)
        {
            return await _context.Payroll
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(p => p.PayrollId == payrollId)
                .ConfigureAwait(false);
        }

        public async Task<List<Payroll>> GetAllPayrollsAsync()
        {
            return await _context.Payroll
                .Include(p => p.Employee)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Payroll> CreateOrUpdatePayrollAsync(Payroll payroll)
        {
            if (payroll.PayrollId == 0)
                _context.Payroll.Add(payroll);
            else
                _context.Payroll.Update(payroll);

            await _context.SaveChangesAsync();
            return await _context.Payroll
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(p => p.PayrollId == payroll.PayrollId);
        }


        public async Task<bool> DeletePayrollAsync(int payrollId)
        {
            var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
            if (payroll == null) return false;

            _context.Payroll.Remove(payroll);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return true;
        }

        public async Task<float> CalculateNetSalaryAsync(int payrollId)
        {
            var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
            if (payroll == null) throw new Exception("Payroll not found");

            payroll.NetSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions;
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return (float)payroll.NetSalary;
        }

        public async Task<byte[]> GeneratePayslipPdfAsync(int employeeId)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == employeeId);

            if (employee == null)
                throw new KeyNotFoundException($"Employee with ID {employeeId} does not exist.");

            var payroll = await _context.Payroll
                .Include(p => p.Employee)
                .Where(p => p.EmployeeId == employeeId)
                .OrderByDescending(p => p.PayrollId)
                .FirstOrDefaultAsync();

            if (payroll == null)
                throw new Exception("No payroll record found for this employee.");

            var culture = new CultureInfo("am-ET");
            var employeeName = $"{payroll.Employee.FirstName} {payroll.Employee.LastName}";
            var date = DateTime.Now.ToString("MMMM yyyy", culture);

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(30);
                    page.Header().Row(row =>
                    {
                        row.ConstantItem(60).Column(col =>
                        {
                            try
                            {
                                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Asset", "Black_and_Gold_Vintage_Luxury_Hotel_Logo-removebg-preview.png");

                                if (!File.Exists(imagePath))
                                    throw new FileNotFoundException($"Image not found at: {imagePath}");

                                using var imageStream = File.OpenRead(imagePath);
                                col.Item().Image(imageStream).FitArea();
                            }
                            catch (Exception ex)
                            {
                                col.Item().Text($"[Logo Error: {ex.Message}]").FontSize(8).Italic().FontColor(Colors.Red.Medium);
                            }

                        });

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("Solmile Guesthouse").FontSize(18).Bold().FontColor(Colors.Black).AlignCenter();
                            col.Item().Text("Payroll Slip / የክፍያ ዝርዝር").FontSize(14).FontColor(Colors.Grey.Darken2).AlignCenter();
                            col.Item().Text(date).FontSize(10).Italic().FontColor(Colors.Grey.Medium).AlignCenter();
                        });
                    });

                    page.Content().PaddingVertical(20).Column(col =>
                    {
                        col.Spacing(10);

                        col.Item().Text("👤 Employee Information").Bold().FontSize(12).Underline();
                        col.Item().Row(r =>
                        {
                            r.RelativeItem().Text($"👤 Name: {employeeName}").FontSize(11);
                            r.RelativeItem().Text($"📅 Date: {DateTime.Now:yyyy-MM-dd}").FontSize(11);
                        });

                        col.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                        col.Item().Text("💵 Payroll Summary").Bold().FontSize(12).Underline();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(cols =>
                            {
                                cols.RelativeColumn(2);
                                cols.RelativeColumn(1);
                            });

                            void AddRow(string label, string value, bool bold = false)
                            {
                                var cell0 = table.Cell().Text(label).FontSize(11);
                                var cell1 = table.Cell().Text(value).FontSize(11).AlignRight();

                                if (bold)
                                {
                                    cell0.Bold();
                                    cell1.Bold().FontColor(Colors.Green.Darken2);
                                }
                            }

                            AddRow("አጠቃላይ ደመወዝ (Basic Salary)", $"{payroll.BasicSalary:N2} ETB");
                            AddRow("ተጨማሪ ክፍያ (Allowances)", $"{payroll.Allowances:N2} ETB");
                            AddRow("መቀነሻ (Deductions)", $"-{payroll.Deductions:N2} ETB");

                            if (!string.IsNullOrEmpty(payroll.DeductionReason))
                            {
                                AddRow("ምክንያት (Deduction Reason)", payroll.DeductionReason);
                            }

                            var netSalary = payroll.BasicSalary + payroll.Allowances - payroll.Deductions;
                            AddRow("የቀረ ክፍያ (Net Salary)", $"{netSalary:N2} ETB", bold: true);
                        });

                        col.Item().PaddingTop(20).Row(row =>
                        {
                            row.RelativeItem().Text("✍️ Signature: ____________________________");
                            row.RelativeItem().Text("📍 Stamp: ____________________________").AlignRight();
                        });
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("📄 Generated on ").SemiBold().FontSize(9).FontColor(Colors.Grey.Darken2);
                        text.Span($"{DateTime.Now:yyyy-MM-dd HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken2);
                    });
                });
            });

            using var stream = new MemoryStream();
            document.GeneratePdf(stream);
            var pdfBytes = stream.ToArray();

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedPayrollslips");
            Directory.CreateDirectory(folderPath);

            string safeName = string.Join("_", (employeeName ?? "Unknown").Split(Path.GetInvalidFileNameChars()));
            string filePath = Path.Combine(folderPath, $"Payslip_{safeName}_{DateTime.Now:yyyyMMddHHmmss}.pdf");

            await File.WriteAllBytesAsync(filePath, pdfBytes);

            return pdfBytes;
        }


        public async Task<List<Payroll>> GetPayrollsByEmployeeIdAsync(int employeeId)
        {
            return await _context.Payroll
                .Where(p => p.EmployeeId == employeeId)
                .Include(p => p.Employee)
                .ToListAsync()
                .ConfigureAwait(false);
        }     

        public async Task AddDeductionAsync(int payrollId, float amount, string reason)
        {
            var payroll = await GetPayrollByIdAsync(payrollId).ConfigureAwait(false);
            if (payroll == null) throw new Exception("Payroll not found");

            payroll.Deductions += amount;
            payroll.DeductionReason = reason;
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
        public async Task<List<Payroll>> GetPayrollsByDateAsync(DateTime payPeriod)
        {
            return await _context.Payroll
                .Include(p => p.Employee)
                .Where(p => p.PayPeriod.Date == payPeriod.Date)
                .ToListAsync();
        }
        public async Task<byte[]> GeneratePayrollPdfByDateAsync(DateTime payPeriod)
        {
            var payrolls = await GetPayrollsByDateAsync(payPeriod);

            if (!payrolls.Any())
                return null;

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
            return stream.ToArray();

            static IContainer CellStyle(IContainer container) => container.PaddingVertical(2);
        }
    }
    }