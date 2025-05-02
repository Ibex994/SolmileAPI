using SolmileAPI.DTO;
using SolmileAPI.Enum;
using SolmileAPI.Models;

namespace SolmileAPI.Interface
{
    public interface AttendanceInterface
    {
        Task<List<EmployeeAttendance>> GetAllAsync();

        Task<EmployeeAttendance?> GetByEmployeeIdAndDateAsync(int employeeId, DateTime date);

        Task<List<EmployeeAttendance>> GetByEmployeeIdAsync(int employeeId);

        Task<List<EmployeeAttendance>> GetAttendanceByDateAsync(DateTime attendanceDate);

        Task<bool> CreateDailyAttendanceAsync(DateTime date, List<EmployeeAttendance> employeeAttendances);

        Task<(AttendanceResponse Response, EmployeeAttendance? Data)> UpdateEmployeeAttendanceAsync(EmployeeAttendance updated);
        Task<bool> DeleteAttendanceAsync(int employeeId, DateTime attendanceDate);



    }
}
