using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solmile.DTO;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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