using Solmile.Models;
using SolmileAPI.DTO;

namespace SolmileAPI.Interface
{
    public interface EmployeeTaskInterface
    {
        Task<TaskCreationResult> CreateTaskAsync(EmployeeTask task);
        Task<EmployeeTask> GetTaskDetailsAsync(int taskId);
        Task<List<EmployeeTask>> ViewAssignedTasksAsync(int employeeId);
        Task<bool> UpdateTaskAsync(int taskId, EmployeeTask updatedTask);
        Task<bool> UpdateTaskDetailsAsync(int taskId, string taskDetails);
        Task<bool> UpdateTaskStatusAsync(int taskId, string status);
        Task<bool> MarkAsCompletedAsync(int taskId);
        Task<bool> DeleteTaskAsync(int taskId);
        Task<bool> AssignTaskAsync(int requestId, int employeeId);
    }
}
