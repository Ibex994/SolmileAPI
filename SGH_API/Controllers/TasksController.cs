using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "HR,Supervisor")]
    public class TasksController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public TasksController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDto>>> GetTasks()
        {
            return await _context.Tasks
                .Select(t => new TaskDto
                {
                    TaskId = t.TaskId,
                    RequestId = t.RequestId,
                    EmployeeId = t.EmployeeId,
                    AssignedTime = t.AssignedTime,
                    Status = t.Status
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return new TaskDto
            {
                TaskId = task.TaskId,
                RequestId = task.RequestId,
                EmployeeId = task.EmployeeId,
                AssignedTime = task.AssignedTime,
                Status = task.Status
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, UInsertionTaskDto taskDto)
        {
            

            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            task.RequestId = taskDto.RequestId;
            task.EmployeeId = taskDto.EmployeeId;
            task.AssignedTime = taskDto.AssignedTime;
            task.Status = taskDto.Status;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
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

        [HttpPost]
        public async Task<ActionResult<TaskDto>> PostTask(UInsertionTaskDto taskDto)
        {
            var task = new Data.Models.Task
            {
                RequestId = taskDto.RequestId,
                EmployeeId = taskDto.EmployeeId,
                AssignedTime = taskDto.AssignedTime,
                Status = taskDto.Status
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            taskDto.TaskId = task.TaskId;
            return new TaskDto
            {
                TaskId = task.TaskId,
                RequestId = task.RequestId,
                EmployeeId = task.EmployeeId,
                AssignedTime = task.AssignedTime,
                Status = task.Status
            };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskId == id);
        }

        [HttpGet("FindByServiceRequest/{serviceRequestId}")]
        public async Task<ActionResult<TaskDto>> FindTaskByServiceRequest(int serviceRequestId)
        {
            var task = await _context.Tasks
                .FirstOrDefaultAsync(t => t.RequestId == serviceRequestId);

            if (task == null)
            {
                return NotFound();
            }

            return new TaskDto
            {
                TaskId = task.TaskId,
                RequestId = task.RequestId,
                EmployeeId = task.EmployeeId,
                AssignedTime = task.AssignedTime,
                Status = task.Status
            };
        }

        [HttpGet("FindEmployeeIdByRequestId/{requestId}")]
        public async Task<ActionResult<int>> FindEmployeeIdByRequestId(int requestId)
        {
            var task = await _context.Tasks
                .FirstOrDefaultAsync(t => t.RequestId == requestId);

            if (task == null)
            {
                return -1;
            }

            return task.EmployeeId;
        }
    }
}