using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

    namespace SolmileGuesthouseAPI.Repository
    {
        public class TaxRepo : TaxInterface
        {
            private readonly GuesthouseDbContext _context;

            public TaxRepo(GuesthouseDbContext context)
            {
                _context = context;
            }
        public async Task<TaxResultDto> CalculateTaxAsync(float basicSalary)
        {
            decimal salary = (decimal)basicSalary;
            var bracket = await _context.TaxBrackets
                .FirstOrDefaultAsync(b => salary >= b.From && salary <= b.To);

            if (bracket == null)
                return null;
            decimal taxRate = bracket.RatePercent / 100m;
            decimal taxAmount = (salary * taxRate) - bracket.Deductible;
            if (taxAmount < 0) taxAmount = 0; 

            decimal netSalary = salary - taxAmount;

            return new TaxResultDto
            {
                TaxAmount = taxAmount,
                NetSalary = netSalary
            };
        }
        public async Task<string> ViewTaxDetailsAsync(int employeeId)
            {
                var tax = await _context.Taxs.FirstOrDefaultAsync(t => t.EmployeeId == employeeId);
                if (tax == null)
                    return "No tax details available for this employee.";

                return $"Employee ID: {tax.EmployeeId}, Tax Rate: {tax.TaxRate}, Tax Amount: {tax.TaxAmount}";
            }

            public async Task<Tax> GetTaxByIdAsync(int taxId)
            {
                return await _context.Taxs.FindAsync(taxId);
            }

            public async Task<IEnumerable<Tax>> GetAllTaxesAsync()
            {
                return await _context.Taxs.ToListAsync();
            }

        public async Task<Tax> CreateTaxAsync(Tax tax)
        {
            var employeeExists = await _context.Employees.AnyAsync(e => e.Id == tax.EmployeeId);
            if (!employeeExists)
                throw new ArgumentException("Employee not found");

            _context.Taxs.Add(tax);
            await _context.SaveChangesAsync();
            return tax;
        }

        public async Task<Tax> UpdateTaxAsync(int taxId, Tax updatedTax)
            {
                var tax = await _context.Taxs.FindAsync(taxId);
                if (tax == null)
                    return null;

                tax.EmployeeId = updatedTax.EmployeeId;
                tax.TaxRate = updatedTax.TaxRate;
                tax.TaxAmount = updatedTax.TaxAmount;

                await _context.SaveChangesAsync();
                return tax;
            }

            public async Task<bool> DeleteTaxAsync(int taxId)
            {
                var tax = await _context.Taxs.FindAsync(taxId);
                if (tax == null)
                    return false;

                _context.Taxs.Remove(tax);
                await _context.SaveChangesAsync();
                return true;
            }

        public async Task<IEnumerable<Tax>> GetTaxesByEmployeeIdAsync(int employeeId)
        {
            return await _context.Taxs
                .Where(t => t.EmployeeId == employeeId)
                .ToListAsync();
        }

    }
}
