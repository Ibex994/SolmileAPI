using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTaskController : Controller
    {
        private readonly EmployeeTaskInterface _employeeTaskInterface;
        private readonly IMapper _mapper;

        public EmployeeTaskController(EmployeeTaskInterface employeeTaskInterface, IMapper mapper)
        {
            _employeeTaskInterface = employeeTaskInterface;
            _mapper = mapper;
        }

        [HttpGet("Detaild")]
        [ProducesResponseType(typeof(EmpTaskDto), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<EmpTaskDto>> GetTask(int Taskid)
        {
            var task = await _employeeTaskInterface.GetTaskDetailsAsync(Taskid);
            if (task == null) return NotFound("Task not found.");
            return Ok(_mapper.Map<EmpTaskDto>(task));
        }

        [HttpGet("Assigned/{employeeId}")]
        [ProducesResponseType(typeof(List<EmployeeTaskDto>), 200)]
        public async Task<ActionResult<List<EmployeeTaskDto>>> GetTasksByEmployee(int employeeId)
        {
            var tasks = await _employeeTaskInterface.ViewAssignedTasksAsync(employeeId);
            return Ok(_mapper.Map<List<EmployeeTaskDto>>(tasks));
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(CreateEmployeeTaskDto), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateTask(CreateEmployeeTaskDto taskDto)
        {
            var task = _mapper.Map<EmployeeTask>(taskDto);
            var result = await _employeeTaskInterface.CreateTaskAsync(task);

            if (!result.Success)
                return BadRequest(result.Message);

            var createdDto = _mapper.Map<CreateEmployeeTaskDto>(result.Task);
            return CreatedAtAction(nameof(GetTask), new { id = result.Task.TaskId }, createdDto);
        }


        [HttpPut("Update")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateTask(int Taskid, EmployeeTaskDto updatedDto)
        {
            var task = _mapper.Map<EmployeeTask>(updatedDto);
            var success = await _employeeTaskInterface.UpdateTaskAsync(Taskid, task);
            if (!success) 
                return NotFound("Task not found.");
            return Ok("Task updated successfully.");
        }

        [HttpPatch("UpdateDetails")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateTaskDetails(int Taskid, [FromBody] string taskDetails)
        {
            var success = await _employeeTaskInterface.UpdateTaskDetailsAsync(Taskid, taskDetails);
            if (!success) 
                return NotFound("Task not found.");
            return Ok("Task details updated successfully.");
        }

        [HttpPatch("Status")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> SetStatusToPending(int Taskid)
        {
            var success = await _employeeTaskInterface.UpdateTaskStatusAsync(Taskid, null);
            if (!success) 
                return NotFound("Task not found.");
            return Ok("Task status set to pending.");
        }

        [HttpPatch("Complete")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> MarkAsCompleted(int Taskid)
        {
            var success = await _employeeTaskInterface.MarkAsCompletedAsync(Taskid);
            if (!success) 
                return NotFound("Task not found.");
            return Ok("Task marked as completed.");
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> DeleteTask(int Taskid)
        {
            var success = await _employeeTaskInterface.DeleteTaskAsync(Taskid);
            if (!success) 
                return NotFound("Task not found.");
            return Ok("Task deleted successfully.");
        }

        [HttpPost("Assign")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> AssignTask([FromBody] AssignTaskDto assignDto)
        {
            var success = await _employeeTaskInterface.AssignTaskAsync(assignDto.RequestId, assignDto.EmployeeId);
            if (!success) 
                return BadRequest("Assignment failed.");
            return Ok("Task assigned successfully.");
        }
    }
}
