using System.Linq;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
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
        public async Task<bool> CreateDailyEmployeeAttendanceAsync(DateTime date, List<EmployeeAttendance> employeeAttendances)
        {
            // Verify all employee IDs exist first
            var employeeIds = employeeAttendances.Select(e => e.EmployeeId).ToList();
            var existingEmployees = await _context.Users
                .Where(u => employeeIds.Contains(u.Id))
                .Select(u => u.Id)
                .ToListAsync();

            var invalidIds = employeeIds.Except(existingEmployees).ToList();
            if (invalidIds.Any())
            {
                throw new ArgumentException($"The following employee IDs don't exist: {string.Join(", ", invalidIds)}");
            }
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
                EmployeeAttendances = employeeAttendances.Select(ea => new EmployeeAttendance
                {
                    EmployeeId = ea.EmployeeId,
                    EmployeeFullName = ea.EmployeeFullName,
                    AttendanceDate = ea.AttendanceDate,
                    IsPresent = ea.IsPresent,
                    Reason = ea.Reason
                }).ToList()
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

        public async Task<bool> CreateDailyAttendanceAsync(DateTime attendanceDate)
        {
            var exists = await _context.Attendances.AnyAsync(a => a.AttendanceDate.Date == attendanceDate.Date);
            if (exists)
                return false;

            var attendance = new Attendance
            {
                AttendanceDate = attendanceDate.Date
            };

            await _context.Attendances.AddAsync(attendance);
            await _context.SaveChangesAsync(); 

            var employees = await _context.Employees.ToListAsync();

            var attendanceRecords = employees.Select(emp => new EmployeeAttendance
            {
                EmployeeId = emp.Id,
                AttendanceDate = attendanceDate.Date,
                EmployeeFullName = emp.Username,
                AttendanceId = attendance.AttendanceId,
                IsPresent = true,
                Reason = null
            }).ToList();

            await _context.EmployeeAttendances.AddRangeAsync(attendanceRecords);
            await _context.SaveChangesAsync();

            return true;
        }


        public async Task<IEnumerable<DateTime>> GetAllAttendanceDatesAsync()
        {
            return await _context.EmployeeAttendances
                                 .Select(a => a.AttendanceDate.Date)
                                 .Distinct()
                                 .OrderByDescending(d => d)
                                 .ToListAsync();
        }

    }
}
