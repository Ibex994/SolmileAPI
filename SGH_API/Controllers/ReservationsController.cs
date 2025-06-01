using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.Data;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Microsoft.AspNetCore.Authorization;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuesthouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Manager,Reception")]
    public class ReservationsController : ControllerBase
    {
        private readonly GuesthouseDbContext _context;

        public ReservationsController(GuesthouseDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationDto>>> GetReservations()
        {
            return await _context.Reservations
                .Select(r => new ReservationDto
                {
                    ReservationId = r.ReservationId,
                    CustomerId = r.CustomerId,
                    RoomId = r.RoomId,
                    CheckInDate = r.CheckInDate,
                    CheckOutDate = r.CheckOutDate,
                    TotalPrice = r.TotalPrice,
                    DoorKey = r.DoorKey,
                    Status = r.Status
                })
                .ToListAsync();
        }

        // GET: api/Reservations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationDto>> GetReservation(string id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return new ReservationDto
            {
                ReservationId = reservation.ReservationId,
                CustomerId = reservation.CustomerId,
                RoomId = reservation.RoomId,
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                TotalPrice = reservation.TotalPrice,
                DoorKey = reservation.DoorKey,
                Status = reservation.Status
            };
        }

        // PUT: api/Reservations/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutReservation(string id, UpdateReservationDto reservationDto)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            reservation.Status = reservationDto.Status;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationExists(id))
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
        [HttpPatch("CheckInOut/{id}")]
        public async Task<IActionResult> PutReservation(string id, doorKeyUpdateReservationDto reservationDto)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            // Check if door key is changing from true to false
            bool shouldCreateServiceRequest = reservation.DoorKey && !reservationDto.DoorKey;

            reservation.DoorKey = reservationDto.DoorKey;

            try
            {
                await _context.SaveChangesAsync();

                // If door key changed from true to false, create a service request
                if (shouldCreateServiceRequest)
                {
                    var room = await _context.Rooms.FindAsync(reservation.RoomId);
                    var realRoomNum = await _context.RoomNumberAssignments.FindAsync(room.RoomNumberAssignmentId);

                    var serviceRequest = new ServiceRequest
                    {
                        RequestedBy = "Customer",
                        ReservationId = reservation.ReservationId,
                        EmployeeId = null,
                        ServiceTypeId = 1, // Assuming 1 is for cleaning service
                        Location = realRoomNum.RoomNumber.ToString(),
                        RequiredByDateTime = DateTime.Now,
                        Status = "Pending",
                        ExtraDetail = "Full Cleaning Service",
                        AttachPhotoUrl = null
                    };

                    _context.ServiceRequests.Add(serviceRequest);
                    await _context.SaveChangesAsync();

                    // Assign the service request to an employee
                    var assignRequest = new AssignServiceRequestRequest
                    {
                        ServiceRequestId = serviceRequest.RequestId
                    };

                    var serviceRequestsController = new ServiceRequestsController(_context);
                    await serviceRequestsController.AssignServiceRequestToEmployee(assignRequest);
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationExists(id))
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

        // POST: api/Reservations
        [HttpPost]
        public async Task<ActionResult<ReservationDto>> PostReservation(string location, int roomTypeId, InsertionReservationDto reservationDto)
        {
            var availableRooms = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.RoomNumberAssignment)
                .ThenInclude(rna => rna.Branch)
                .Where(r =>
                    r.RoomNumberAssignment.Branch.Location == location &&
                    r.TypeId == roomTypeId &&
                    r.Status == "Available")
                .ToListAsync();

            Room availableRoom = null;
            foreach (var room in availableRooms)
            {
                var hasConflict = await _context.Reservations
                    .AnyAsync(r =>
                        r.RoomId == room.RoomId &&
                        r.Status != "Cancelled" &&
                        !(reservationDto.CheckOutDate < r.CheckInDate || reservationDto.CheckInDate > r.CheckOutDate));

                if (!hasConflict)
                {
                    availableRoom = room;
                    break;
                }
            }

            if (availableRoom == null)
            {
                return NotFound("No available rooms found for the selected criteria and dates");
            }

            var numberOfDays = (reservationDto.CheckOutDate - reservationDto.CheckInDate).Days + 1;
            var totalPrice = numberOfDays * availableRoom.RoomType.PricePerNight;

            var reservation = new Reservation
            {
                ReservationId = GenerateUniqueReservationId(),
                CustomerId = reservationDto.CustomerId,
                RoomId = availableRoom.RoomId,
                CheckInDate = reservationDto.CheckInDate,
                CheckOutDate = reservationDto.CheckOutDate,
                TotalPrice = totalPrice,
                Status = "Pending"
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            
            var payment = new Payment
            {
                ReservationId = reservation.ReservationId,
                Amount = reservation.TotalPrice,
                PaymentDate = DateTime.Now,
                MethodId = reservationDto.PaymentMethodId
            };

            _context.payments.Add(payment);
            await _context.SaveChangesAsync();

            var savedPayment = await _context.payments
                .Include(p => p.PaymentMethod)
                .FirstOrDefaultAsync(p => p.ReservationId == reservation.ReservationId);

            string paymentMethod = savedPayment?.PaymentMethod?.MethodName ?? "N/A";

            var customer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == reservation.CustomerId);

            if (customer == null)
                return BadRequest("Customer not found");

            var resultDto = new ReservationDto
            {
                ReservationId = reservation.ReservationId,
                CustomerId = reservation.CustomerId,
                RoomId = reservation.RoomId,
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                TotalPrice = reservation.TotalPrice,
                DoorKey = reservation.DoorKey,
                Status = reservation.Status
            };

            var pdfSlip = new PdfSlipGenerator(slipDto);

            string folderPath = @"C:\Users\Temeb\source\repos\Ibex994\SolmileAPI\SGH_API\GeneratedSlip";
            Directory.CreateDirectory(folderPath);

            string fileName = $"Slip-{slipDto.ReservationCode}-{customer.FirstName}.pdf";
            string filePath = Path.Combine(folderPath, fileName);

            pdfSlip.SaveToFile(filePath);

            return CreatedAtAction("GetReservation", new { id = reservation.ReservationId }, resultDto);
        }

        // DELETE: api/Reservations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(string id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Reservations/findByIdAndLastName
        [HttpGet("findByIdAndLastName")]
        public async Task<ActionResult<ReservationDto>> FindReservationByIdAndLastName(string id, string lastName)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(r => r.ReservationId == id && r.Customer.LastName == lastName);

            if (reservation == null)
            {
                return NotFound();
            }

            return new ReservationDto
            {
                ReservationId = reservation.ReservationId,
                CustomerId = reservation.CustomerId,
                RoomId = reservation.RoomId,
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                TotalPrice = reservation.TotalPrice,
                DoorKey = reservation.DoorKey,
                Status = reservation.Status
            };
        }

        // GET: api/Reservations/findRoomTypeByRoomId/ABC123
        [HttpGet("findRoomTypeByRoomId/{roomId}")]
        public async Task<ActionResult<string>> FindRoomTypeByRoomId(string roomId)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(r => r.RoomId == roomId);

            if (room == null || room.RoomType == null)
            {
                return NotFound();
            }

            return room.RoomType.Name;
        }

        // GET: api/Reservations/findBranchLocationByRoomId/ABC123
        [HttpGet("findBranchLocationByRoomId/{roomId}")]
        public async Task<ActionResult<string>> FindBranchLocationByRoomId(string roomId)
        {
            var room = await _context.Rooms
                .Include(r => r.RoomNumberAssignment)
                .ThenInclude(rna => rna.Branch)
                .FirstOrDefaultAsync(r => r.RoomId == roomId);

            if (room?.RoomNumberAssignment?.Branch == null)
            {
                return NotFound();
            }

            return room.RoomNumberAssignment.Branch.Location;
        }

        private bool ReservationExists(string id)
        {
            return _context.Reservations.Any(e => e.ReservationId == id);
        }

        private string GenerateUniqueReservationId()
        {
            string reservationId;
            do
            {
                reservationId = GenerateRandomString();
            } while (ReservationExists(reservationId));

            return reservationId;
        }

        private string GenerateRandomString()
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            return new string(Enumerable.Repeat(letters, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}