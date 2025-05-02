using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class LogRepo : LogInterface
    {
        private readonly DataContext _context;

        public LogRepo(DataContext context)
        {
            _context = context;
        }

            public async Task<bool> CreateLogAsync(string action, LogLevel level, int? performedBy)
        {
            var log = new Log
            {
                Action = action,
                Level = level,
                PerformedBy = performedBy,
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

