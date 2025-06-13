namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class EmployeeAttendanceDto
    {
        public int EmployeeId { get; set; }
        public bool IsPresent { get; set; }
        public string? Reason { get; set; }
        public DateTime AttendanceDate { get; set; }
    }

    public class AttendanceCreateDto
    {
        public DateTime AttendanceDate { get; set; }
        public List<EmployeeAttendanceDto> EmployeeAttendances { get; set; } = new();
    }
    public class UpdateEmployeeAttendanceDto
    {
        public int EmployeeId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool IsPresent { get; set; }
        public string? Reason { get; set; }
    }
}
