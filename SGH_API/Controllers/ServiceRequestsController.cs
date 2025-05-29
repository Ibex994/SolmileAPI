using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Supervisor,Reception,Customr")]
    public class ServiceRequestsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public ServiceRequestsController(GuesthouseDbContext context)
        {
            _context = context;
        }

        // GET: api/ServiceRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceRequestDto>>> GetServiceRequests()
        {
            return await _context.ServiceRequests
                .Select(s => new ServiceRequestDto
                {
                    RequestId = s.RequestId,
                    RequestedBy = s.RequestedBy,
                    ReservationId = s.ReservationId,
                    EmployeeId = s.EmployeeId,
                    ServiceTypeId = s.ServiceTypeId,
                    Location = s.Location,
                    RequiredByDateTime = s.RequiredByDateTime,
                    Status = s.Status,
                    ExtraDetail = s.ExtraDetail,
                    AttachPhotoUrl = s.AttachPhotoUrl
                })
                .ToListAsync();
        }

        // GET: api/ServiceRequests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceRequestDto>> GetServiceRequest(int id)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);

            if (serviceRequest == null)
            {
                return NotFound();
            }

            return new ServiceRequestDto
            {
                RequestId = serviceRequest.RequestId,
                RequestedBy = serviceRequest.RequestedBy,
                ReservationId = serviceRequest.ReservationId,
                EmployeeId = serviceRequest.EmployeeId,
                ServiceTypeId = serviceRequest.ServiceTypeId,
                Location = serviceRequest.Location,
                RequiredByDateTime = serviceRequest.RequiredByDateTime,
                Status = serviceRequest.Status,
                ExtraDetail = serviceRequest.ExtraDetail,
                AttachPhotoUrl = serviceRequest.AttachPhotoUrl
            };
        }

        // PUT: api/ServiceRequests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceRequest(int id, [FromForm] UInsertionServiceRequestDto serviceRequestDto)
        {

            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest == null)
            {
                return NotFound();
            }
            
            if (serviceRequestDto.AttachPhotoUrl != null)
            {
                using var stream = new MemoryStream();
                await serviceRequestDto.AttachPhotoUrl.CopyToAsync(stream);
                serviceRequest.AttachPhotoUrl = stream.ToArray();
           }

            serviceRequest.RequestedBy = serviceRequestDto.RequestedBy;
            serviceRequest.ReservationId = serviceRequestDto.ReservationId;
            serviceRequest.EmployeeId = serviceRequestDto.EmployeeId;
            serviceRequest.ServiceTypeId = serviceRequestDto.ServiceTypeId;
            serviceRequest.Location = serviceRequestDto.Location;
            serviceRequest.RequiredByDateTime = serviceRequestDto.RequiredByDateTime;
            serviceRequest.ExtraDetail = serviceRequestDto.ExtraDetail;
       
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceRequestExists(id))
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

        // POST: api/ServiceRequests
        [HttpPost]
        public async Task<ActionResult<ServiceRequestDto>> PostServiceRequest([FromForm] UInsertionServiceRequestDto serviceRequestDto)
        {
            var serviceRequest = new ServiceRequest
            {
                RequestedBy = serviceRequestDto.RequestedBy,
                ReservationId = serviceRequestDto.ReservationId,
                EmployeeId = serviceRequestDto.EmployeeId,
                ServiceTypeId = serviceRequestDto.ServiceTypeId,
                Location = serviceRequestDto.Location,
                RequiredByDateTime = serviceRequestDto.RequiredByDateTime,
                Status = "Pending",
                ExtraDetail = serviceRequestDto.ExtraDetail,
                AttachPhotoUrl = null
            };
            // Only process image if provided
            if (serviceRequestDto.AttachPhotoUrl != null)
            {
                using var stream = new MemoryStream();
                await serviceRequestDto.AttachPhotoUrl.CopyToAsync(stream);
                serviceRequest.AttachPhotoUrl = stream.ToArray();
            }

            _context.ServiceRequests.Add(serviceRequest);
            await _context.SaveChangesAsync();

          //  serviceRequestDto.RequestId = serviceRequest.RequestId;
            return new ServiceRequestDto
            {
                RequestId = serviceRequest.RequestId,
                RequestedBy = serviceRequest.RequestedBy,
                ReservationId = serviceRequest.ReservationId,
                EmployeeId = serviceRequest.EmployeeId,
                ServiceTypeId = serviceRequest.ServiceTypeId,
                Location = serviceRequest.Location,
                RequiredByDateTime = serviceRequest.RequiredByDateTime,
                Status = serviceRequest.Status,
                ExtraDetail = serviceRequest.ExtraDetail,
                AttachPhotoUrl =serviceRequest.AttachPhotoUrl
            };




        }

        // DELETE: api/ServiceRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceRequest(int id)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);
            if (serviceRequest == null)
            {
                return NotFound();
            }

            _context.ServiceRequests.Remove(serviceRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServiceRequestExists(int id)
        {
            return _context.ServiceRequests.Any(e => e.RequestId == id);
        }

        // GET: api/ServiceRequestExtensions/FindById/5
        [HttpGet("FindById/{id}")]
        public async Task<ActionResult<ServiceRequestDto>> FindServiceRequestById(int id)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(id);

            if (serviceRequest == null)
            {
                return NotFound();
            }

            return new ServiceRequestDto
            {
                RequestId = serviceRequest.RequestId,
                RequestedBy = serviceRequest.RequestedBy,
                ReservationId = serviceRequest.ReservationId,
                EmployeeId = serviceRequest.EmployeeId,
                ServiceTypeId = serviceRequest.ServiceTypeId,
                Location = serviceRequest.Location,
                RequiredByDateTime = serviceRequest.RequiredByDateTime,
                Status = serviceRequest.Status,
                ExtraDetail = serviceRequest.ExtraDetail,
                AttachPhotoUrl = serviceRequest.AttachPhotoUrl
            };
        }

        // GET: api/ServiceRequestExtensions/GetByReservationId/ABC123
        [HttpGet("GetByReservationId/{reservationId}")]
        public async Task<ActionResult<IEnumerable<ServiceRequestDto>>> GetServiceRequestsByReservationId(string reservationId)
        {
            var serviceRequests = await _context.ServiceRequests
                .Where(sr => sr.ReservationId == reservationId)
                .Select(sr => new ServiceRequestDto
                {
                    RequestId = sr.RequestId,
                    RequestedBy = sr.RequestedBy,
                    ReservationId = sr.ReservationId,
                    EmployeeId = sr.EmployeeId,
                    ServiceTypeId = sr.ServiceTypeId,
                    Location = sr.Location,
                    RequiredByDateTime = sr.RequiredByDateTime,
                    Status = sr.Status,
                    ExtraDetail = sr.ExtraDetail,
                    AttachPhotoUrl = sr.AttachPhotoUrl
                })
                .ToListAsync();

            return serviceRequests;
        }

        // GET: api/ServiceRequestExtensions/GetTasksAndRequestsForEmployee/5
        [HttpGet("GetTasksAndRequestsForEmployee/{employeeId}")]
        public async Task<ActionResult<EmployeeTasksAndRequestsResponse>> GetTasksAndRequestsAssignedToEmployee(int employeeId)
        {
            var tasks = await _context.Tasks
                .Where(t => t.EmployeeId == employeeId)
                .ToListAsync();

            var serviceRequestIds = tasks.Select(t => t.RequestId).Distinct();

            var serviceRequests = await _context.ServiceRequests
                .Where(sr => serviceRequestIds.Contains(sr.RequestId))
                .ToListAsync();

            return new EmployeeTasksAndRequestsResponse
            {
                Tasks = tasks.Select(t => new TaskDto
                {
                    TaskId = t.TaskId,
                    RequestId = t.RequestId,
                    EmployeeId = t.EmployeeId,
                    AssignedTime = t.AssignedTime,
                    Status = t.Status
                }).ToList(),
                ServiceRequests = serviceRequests.Select(sr => new ServiceRequestDto
                {
                    RequestId = sr.RequestId,
                    RequestedBy = sr.RequestedBy,
                    ReservationId = sr.ReservationId,
                    EmployeeId = sr.EmployeeId,
                    ServiceTypeId = sr.ServiceTypeId,
                    Location = sr.Location,
                    RequiredByDateTime = sr.RequiredByDateTime,
                    Status = sr.Status,
                    ExtraDetail = sr.ExtraDetail,
                    AttachPhotoUrl = sr.AttachPhotoUrl
                }).ToList()
            };
        }

        // GET: api/ServiceRequestExtensions/GetServiceTypeNameById/5
        [HttpGet("GetServiceTypeNameById/{serviceTypeId}")]
        public async Task<ActionResult<string>> GetServiceTypeNameById(int serviceTypeId)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(serviceTypeId);

            if (serviceType == null)
            {
                return NotFound();
            }

            return serviceType.ServiceTypeName;
        }

        // PUT: api/ServiceRequestExtensions/UpdateStatus
        [HttpPut("UpdateStatusTaskServiceRequest")]
        public async Task<IActionResult> UpdateStatus(UpdateStatusTaskServiceRequest request)
        {
            var task = await _context.Tasks.FindAsync(request.TaskId);
            var serviceRequest = await _context.ServiceRequests.FindAsync(request.ServiceRequestId);

            if (task == null || serviceRequest == null)
            {
                return NotFound();
            }

            if (request.NewStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                (task.Status.Equals("Done", StringComparison.OrdinalIgnoreCase) ||
                 serviceRequest.Status.Equals("Done", StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest(new { message = "Cannot cancel a completed task or service request." });
            }

            task.Status = request.NewStatus;
            serviceRequest.Status = request.NewStatus;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/ServiceRequestExtensions/UpdateStatusServiceRequest
        [HttpPut("UpdateStatusServiceRequest")]
        public async Task<IActionResult> UpdateStatusServiceRequest(UpdateStatusServiceRequest request)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(request.ServiceRequestId);

            if (serviceRequest == null)
            {
                return NotFound(new { message = "Service request not found." });
            }

            // Check if the new status is "Cancelled" and the service request is already "Done"
            if (request.NewStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                serviceRequest.Status.Equals("Done", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest(new { message = "Cannot cancel a completed service request." });
            }

            // Update the status
            serviceRequest.Status = request.NewStatus;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/ServiceRequestExtensions/UpdateStatusForReservation
        [HttpPut("UpdateStatusForReservation")]
        public async Task<IActionResult> UpdateStatusForReservation(UpdateStatusForReservationRequest request)
        {
            var serviceRequests = await _context.ServiceRequests
                .Where(sr => sr.ReservationId == request.ReservationId)
                .ToListAsync();

            foreach (var serviceRequest in serviceRequests)
            {
                if (request.NewStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                    serviceRequest.Status.Equals("Done", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                serviceRequest.Status = request.NewStatus;

                var tasks = await _context.Tasks
                    .Where(t => t.RequestId == serviceRequest.RequestId)
                    .ToListAsync();

                foreach (var task in tasks)
                {
                    if (request.NewStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                        task.Status.Equals("Done", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    task.Status = request.NewStatus;
                }
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/ServiceRequestExtensions/AssignServiceRequestToEmployee
        [HttpPost("AssignServiceRequestToEmployee")]
        public async Task<ActionResult<TaskDto>> AssignServiceRequestToEmployee(AssignServiceRequestRequest request)
        {
            var serviceRequest = await _context.ServiceRequests.FindAsync(request.ServiceRequestId);
            if (serviceRequest == null)
            {
                return NotFound(new { message = "Service request not found." });
            }

            var task = await _context.Tasks
               .FirstOrDefaultAsync(t => t.RequestId == serviceRequest.RequestId);

            if (task != null)
            {
                return  new TaskDto
                {
                    TaskId = task.TaskId,
                    RequestId = task.RequestId,
                    EmployeeId = task.EmployeeId,
                    AssignedTime = task.AssignedTime,
                    Status = task.Status
                };
            }


            var position = GetPositionForServiceType(serviceRequest.ServiceTypeId);
            if (position == null)
            {
                return BadRequest(new { message = "No position assigned for this service type." });
            }

            var requiredDate = serviceRequest.RequiredByDateTime.Date;

            int branchId;
            if (serviceRequest.ReservationId != null)
            {
                var reservation = await _context.Reservations
                    .Include(r => r.Room)
                    .ThenInclude(r => r.RoomNumberAssignment)
                    .FirstOrDefaultAsync(r => r.ReservationId == serviceRequest.ReservationId);

                if (reservation?.Room?.RoomNumberAssignment == null)
                {
                    return BadRequest(new { message = "Could not determine branch from reservation." });
                }

                branchId = reservation.Room.RoomNumberAssignment.BranchId;
            }
            else if (serviceRequest.EmployeeId != null)
            {
                var employee = await _context.Employees.FindAsync(serviceRequest.EmployeeId);
                if (employee == null)
                {
                    return BadRequest(new { message = "Employee not found." });
                }
                branchId = employee.BranchId;
            }
            else
            {
                return BadRequest(new { message = "Could not determine branch for service request." });
            }

            var relevantEmployees = await _context.Employees
                .Where(e => e.Position == position && e.Status && e.BranchId == branchId)
                .ToListAsync();

            if (!relevantEmployees.Any())
            {
                return BadRequest(new { message = "No available employees with the required position." });
            }

            // Get task counts for each employee on the required date
            var employeeTaskCounts = await _context.Tasks
                .Include(t => t.ServiceRequest)
                .Where(t => relevantEmployees.Select(e => e.Id).Contains(t.EmployeeId) &&
                    t.ServiceRequest.RequiredByDateTime.Date == requiredDate)
                .GroupBy(t => t.EmployeeId)
                .Select(g => new { EmployeeId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.EmployeeId, x => x.Count);

            // Find employee with least tasks
            var selectedEmployee = relevantEmployees
                .OrderBy(e => employeeTaskCounts.GetValueOrDefault(e.Id, 0))
                .First();

            // Create new task
            var newTask = new Data.Models.Task
            {
                RequestId = serviceRequest.RequestId,
                EmployeeId = selectedEmployee.Id,
                AssignedTime = DateTime.Now,
                Status = "Pending"
            };

            _context.Tasks.Add(newTask);
            await _context.SaveChangesAsync();

            return new TaskDto
            {
                TaskId = newTask.TaskId,
                RequestId = newTask.RequestId,
                EmployeeId = newTask.EmployeeId,
                AssignedTime = newTask.AssignedTime,
                Status = newTask.Status
            };
        }

        private string GetPositionForServiceType(int serviceTypeId)
        {
            return serviceTypeId switch
            {
                1 or 2 => "Housekeeping",
                3 or 4 or 5 => "Chufaree",
                8 => "Manager",
                _ => null
            };
        }
    }

    public class EmployeeTasksAndRequestsResponse
    {
        public List<TaskDto> Tasks { get; set; }
        public List<ServiceRequestDto> ServiceRequests { get; set; }
    }

    public class UpdateStatusTaskServiceRequest
    {
        public int TaskId { get; set; }
        public int ServiceRequestId { get; set; }
        public string NewStatus { get; set; }
    }
    public class UpdateStatusServiceRequest
    {
        public int ServiceRequestId { get; set; }
        public string NewStatus { get; set; }
    }

    public class UpdateStatusForReservationRequest
    {
        public string ReservationId { get; set; }
        public string NewStatus { get; set; }
    }

    public class AssignServiceRequestRequest
    {
        public int ServiceRequestId { get; set; }
    }
}