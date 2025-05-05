using Solmile.Models;

namespace SolmileAPI.DTO
{
    public class EmployeeTaskDto
    {
        public int RequestId { get; set; }
        public int? EmployeeId { get; set; }
        public string TaskDetails { get; set; }
        public string Status { get; set; }

    }
        public class EmpTaskDto
        {
            public int TaskId { get; set; }
            public int RequestId { get; set; }
            public int? EmployeeId { get; set; }
            public string TaskDetails { get; set; }
            public DateTime AssignedTime { get; set; }
            public string Status { get; set; }
            public string? EmployeeName { get; set; }
        }
    public class CreateEmployeeTaskDto
    {
        public int RequestId { get; set; }
        public int? EmployeeId { get; set; }
        public string TaskDetails { get; set; }
        public DateTime AssignedTime { get; set; } = DateTime.UtcNow;
    }


    public class AssignTaskDto
    {
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
    }

    public class TaskCreationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public EmployeeTask? Task { get; set; }
    }

}
