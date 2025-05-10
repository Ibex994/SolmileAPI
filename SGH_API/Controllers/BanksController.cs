using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public BanksController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/Banks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankDto>>> GetBanks()
        {
            return await _context.Banks
                .Select(b => new BankDto
                {
                    Id = b.Id,
                    ImageUrl = b.ImageUrl,
                    BankName = b.BankName,
                    Type = b.Type,
                    IsSelected = b.IsSelected
                })
                .ToListAsync();
        }

        // GET: api/Banks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankDto>> GetBank(int id)
        {
            var bank = await _context.Banks.FindAsync(id);

            if (bank == null)
            {
                return NotFound();
            }

            return new BankDto
            {
                Id = bank.Id,
                ImageUrl = bank.ImageUrl,
                BankName = bank.BankName,
                Type = bank.Type,
                IsSelected = bank.IsSelected
            };
        }

        // PUT: api/Banks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBank(int id, UInsertionBankDto bankDto)
        {
            

            var bank = await _context.Banks.FindAsync(id);
            if (bank == null)
            {
                return NotFound();
            }

            bank.ImageUrl = bankDto.ImageUrl;
            bank.BankName = bankDto.BankName;
            bank.Type = bankDto.Type;
            bank.IsSelected = bankDto.IsSelected;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Banks
        [HttpPost]
        public async Task<ActionResult<BankDto>> PostBank(UInsertionBankDto bankDto)
        {
            var bank = new Bank
            {
                ImageUrl = bankDto.ImageUrl,
                BankName = bankDto.BankName,
                Type = bankDto.Type,
                IsSelected = bankDto.IsSelected
            };

            _context.Banks.Add(bank);
            await _context.SaveChangesAsync();

            bankDto.Id = bank.Id;
            return CreatedAtAction("GetBank", new { id = bank.Id }, bankDto);
        }

        // DELETE: api/Banks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBank(int id)
        {
            var bank = await _context.Banks.FindAsync(id);
            if (bank == null)
            {
                return NotFound();
            }

            _context.Banks.Remove(bank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankExists(int id)
        {
            return _context.Banks.Any(e => e.Id == id);
        }
    }


}
