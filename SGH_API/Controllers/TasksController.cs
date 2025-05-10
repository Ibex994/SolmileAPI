using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public TasksController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/Tasks
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

        // GET: api/Tasks/5
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

        // PUT: api/Tasks/5
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

        // POST: api/Tasks
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
            return CreatedAtAction("GetTask", new { id = task.TaskId }, taskDto);
        }

        // DELETE: api/Tasks/5
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
        // GET: api/TaskExtensions/FindByServiceRequest/5
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

        // GET: api/TaskExtensions/FindEmployeeIdByRequestId/5
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