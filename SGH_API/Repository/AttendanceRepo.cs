using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Enum;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Repository
{
    public class AttendanceRepo : AttendanceInterface
    {
        private readonly GuesthouseDbContext _context;

        public AttendanceRepo(GuesthouseDbContext context)
        {
            _context = context;
        }

        public async Task<List<EmployeeAttendance>> GetAllAsync()
        {
            return await _context.EmployeeAttendances
                .Include(ea => ea.Employee)
                .Include(ea => ea.Attendance)
                .ToListAsync();
        }

        public async Task<EmployeeAttendance?> GetByEmployeeIdAndDateAsync(int employeeId, DateTime date)
        {
            return await _context.EmployeeAttendances
                .Include(ea => ea.Attendance)
                .FirstOrDefaultAsync(ea =>
                    ea.EmployeeId == employeeId &&
                    ea.Attendance.AttendanceDate.Date == date.Date);
        }

        public async Task<List<EmployeeAttendance>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.EmployeeAttendances
                .Include(ea => ea.Attendance)
                .Where(ea => ea.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task<List<EmployeeAttendance>> GetAttendanceByDateAsync(DateTime attendanceDate)
        {
            return await _context.EmployeeAttendances
                .Where(ea => ea.AttendanceDate.Date == attendanceDate.Date)
                .ToListAsync();
        }
        public async Task<bool> CreateDailyAttendanceAsync(DateTime date, List<EmployeeAttendance> employeeAttendances)
        {
            var existing = await _context.Attendances
                .Include(a => a.EmployeeAttendances)
                .FirstOrDefaultAsync(a => a.AttendanceDate.Date == date.Date);

            if (existing != null)
            {
                foreach (var ea in employeeAttendances)
                {
                    var alreadyExists = existing.EmployeeAttendances
                        .Any(e => e.EmployeeId == ea.EmployeeId);

                    if (!alreadyExists)
                    {
                        ea.AttendanceId = existing.AttendanceId;
                        _context.EmployeeAttendances.Add(ea);
                    }
                }

                await _context.SaveChangesAsync();
                return true;
            }

            var attendance = new Attendance
            {
                AttendanceDate = date,
                EmployeeAttendances = employeeAttendances
            };

            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAttendanceAsync(int employeeId, DateTime attendanceDate)
        {
            var attendanceRecord = await _context.EmployeeAttendances
                .Where(ea => ea.EmployeeId == employeeId && ea.AttendanceDate.Date == attendanceDate.Date)
                .FirstOrDefaultAsync();

            if (attendanceRecord == null)
                return false;

            _context.EmployeeAttendances.Remove(attendanceRecord);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<(AttendanceResponse Response, EmployeeAttendance? Data)> UpdateEmployeeAttendanceAsync(EmployeeAttendance updated)
        {
            var existing = await _context.EmployeeAttendances
                .FirstOrDefaultAsync(ea => ea.EmployeeId == updated.EmployeeId);

            if (existing == null)
                return (AttendanceResponse.NotFound, null);

            existing.IsPresent = updated.IsPresent;
            existing.Reason = updated.Reason;

            await _context.SaveChangesAsync();

            return (AttendanceResponse.Success, existing);
        }


    }
}
