using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class EmployeeTaskRepo : EmployeeTaskInterface
    {
        private readonly DataContext _context;

        public EmployeeTaskRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<TaskCreationResult> CreateTaskAsync(EmployeeTask task)
        {
            //if (task.RequestId != 0)
            //{
            //    var alreadyAssigned = await _context.EmployeeTasks
            //        .AnyAsync(t => t.RequestId == task.RequestId && t.EmployeeId != null);

            //    if (alreadyAssigned)
            //    {
            //        return new TaskCreationResult
            //        {
            //            Success = false,
            //            Message = "This request has already been assigned to an employee.",
            //            Task = null
            //        };
            //    }
            //}
            if (task.EmployeeId != null)
            {
                var activeTasks = await _context.EmployeeTasks
                    .CountAsync(t =>
                        t.EmployeeId == task.EmployeeId &&
                        (t.Status == "Pending" || t.Status == "Incomplete" || t.Status == "Assigned"));

                if (activeTasks >= 2)
                {
                    return new TaskCreationResult
                    {
                        Success = false,
                        Message = "Employee already has 2 or more active tasks.",
                        Task = null
                    };
                }
            }
            task.Status ??= "Incomplete";
            _context.EmployeeTasks.Add(task);
            await _context.SaveChangesAsync();

            return new TaskCreationResult
            {
                Success = true,
                Message = "Task created successfully.",
                Task = task
            };
        }


        public async Task<EmployeeTask> GetTaskDetailsAsync(int taskId)
        {
            return await _context.EmployeeTasks
                                 .Include(t => t.Employee)
                                 .Include(t => t.ServiceRequests)
                                 .FirstOrDefaultAsync(t => t.TaskId == taskId);
        }
        public async Task<List<EmployeeTask>> ViewAssignedTasksAsync(int employeeId)
        {
            return await _context.EmployeeTasks
                                 .Where(t => t.EmployeeId == employeeId)
                                 .Include(t => t.Employee) 
                                 .ToListAsync();
        }
        public async Task<bool> UpdateTaskAsync(int taskId, EmployeeTask updatedTask)
        {
            var task = await _context.EmployeeTasks.FindAsync(taskId);
            if (task == null) return false;

            task.TaskDetails = updatedTask.TaskDetails;
            task.Status = updatedTask.Status;
            task.EmployeeId = updatedTask.EmployeeId;
            task.AssignedTime = updatedTask.AssignedTime;

            _context.EmployeeTasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateTaskDetailsAsync(int taskId, string taskDetails)
        {
            var task = await _context.EmployeeTasks.FindAsync(taskId);
            if (task == null) return false;

            task.TaskDetails = taskDetails;
            _context.EmployeeTasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateTaskStatusAsync(int taskId, string status)
        {
            var task = await _context.EmployeeTasks.FindAsync(taskId);
            if (task == null) 
                return false;

            task.Status = "Pending";
            _context.EmployeeTasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> MarkAsCompletedAsync(int taskId)
        {
            var task = await _context.EmployeeTasks.FindAsync(taskId);
            if (task == null) return false;

            task.Status = "Completed";
            _context.EmployeeTasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteTaskAsync(int taskId)
        {
            var task = await _context.EmployeeTasks.FindAsync(taskId);
            if (task == null) return false;

            _context.EmployeeTasks.Remove(task);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> AssignTaskAsync(int requestId, int employeeId)
        {
            var task = await _context.EmployeeTasks
                                     .FirstOrDefaultAsync(t => t.RequestId == requestId && t.EmployeeId == null);

            if (task == null) 
                return false; 

            task.EmployeeId = employeeId;
            task.AssignedTime = DateTime.UtcNow;
            task.Status = "Assigned";

            _context.EmployeeTasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
