using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class LogRepo : LogInterface
    {
        private readonly GuesthouseDbContext _context;

        public LogRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateLogAsync(string action, LogLevel level, int? performedBy, string Fname, string Lname)
        {
            var log = new Log
            {
                Action = action,
                Level = level,
                PerformedBy = performedBy,
                FirstName=Fname,
                LastName=Lname,
                Timestamp = DateTime.UtcNow
            };

            _context.Logs.Add(log);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Log>> GetAllLogsAsync()
        {
            return await _context.Logs.ToListAsync();
        }
        public async Task<List<Log>> GetLogsByEmployeeAsync(int employeeId)
        {
            return await _context.Logs
                                 .Where(log => log.PerformedBy == employeeId)
                                 .ToListAsync();
        }
    }
}
