using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuesthouseAPI.Interface;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Manager")]
    public class LogController : Controller
    {
        private readonly LogInterface _logInterface;
        private readonly IMapper _mapper;

        public LogController(LogInterface logInterface, IMapper mapper)
        {
            _logInterface = logInterface;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllLogs()
        {
            var logs = await _logInterface.GetAllLogsAsync();
            var logDtos = _mapper.Map<List<LogDto>>(logs);
            return Ok(logDtos);
        }

        [HttpGet("employee/{employeeId}")]
        public async Task<IActionResult> GetLogsByEmployee(int employeeId)
        {
            var logs = await _logInterface.GetLogsByEmployeeAsync(employeeId);
            var logDtos = _mapper.Map<List<LogDto>>(logs);
            return Ok(logDtos);
        }

    }
}
