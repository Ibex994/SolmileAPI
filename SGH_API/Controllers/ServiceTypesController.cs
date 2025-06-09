using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Manager")]
    public class ServiceTypesController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public ServiceTypesController(GuesthouseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceTypeDto>>> GetServiceTypes()
        {
            return await _context.ServiceTypes
                .Select(s => new ServiceTypeDto
                {
                    ServiceTypeId = s.ServiceTypeId,
                    ServiceTypeName = s.ServiceTypeName
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceTypeDto>> GetServiceType(int id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);

            if (serviceType == null)
            {
                return NotFound();
            }

            return new ServiceTypeDto
            {
                ServiceTypeId = serviceType.ServiceTypeId,
                ServiceTypeName = serviceType.ServiceTypeName
            };
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceType(int id, UInsertionServiceTypeDto serviceTypeDto)
        {

            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
            {
                return NotFound();
            }

            serviceType.ServiceTypeName = serviceTypeDto.ServiceTypeName;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceTypeExists(id))
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
        public async Task<ActionResult<ServiceTypeDto>> PostServiceType(ServiceTypeDto serviceTypeDto)
        {
            var serviceType = new ServiceType
            {
                ServiceTypeId = serviceTypeDto.ServiceTypeId,
                ServiceTypeName = serviceTypeDto.ServiceTypeName
            };

            _context.ServiceTypes.Add(serviceType);
            await _context.SaveChangesAsync();

            serviceTypeDto.ServiceTypeId = serviceType.ServiceTypeId;
            return new ServiceTypeDto
            {
                ServiceTypeId = serviceType.ServiceTypeId,
                ServiceTypeName = serviceType.ServiceTypeName
            };

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceType(int id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
            {
                return NotFound();
            }

            _context.ServiceTypes.Remove(serviceType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceTypeExists(int id)
        {
            return _context.ServiceTypes.Any(e => e.ServiceTypeId == id);
        }

        [HttpGet("GetServiceTypeIdByName/{name}")]
        public async Task<ActionResult<int>> GetServiceTypeIdByName(string name)
        {
            var serviceType = await _context.ServiceTypes
                .FirstOrDefaultAsync(st => st.ServiceTypeName.ToLower() == name.ToLower());

            if (serviceType == null)
            {
                return -1;
            }

            return serviceType.ServiceTypeId;
        }

        [HttpGet("GetServiceListForCustomer")]
        public async Task<ActionResult<List<string>>> GetServiceListForCustomer()
        {
            var excludedIds = new List<int> { 1, 5, 8 };

            var serviceTypes = await _context.ServiceTypes
                .Where(st => !excludedIds.Contains(st.ServiceTypeId))
                .Select(st => st.ServiceTypeName)
                .ToListAsync();

            serviceTypes.Insert(0, "Pick a service type.");

            return serviceTypes;
        }
    }
}