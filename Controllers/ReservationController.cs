using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solmile.Models;
using SolmileAPI.DTO;
using SolmileAPI.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolmileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationInterface _reservationRepo;
        private readonly IMapper _mapper;

        public ReservationController(ReservationInterface reservationRepo, IMapper mapper)
        {
            _reservationRepo = reservationRepo;
            _mapper = mapper;
        }

        [HttpPost("Create")]
        [ProducesResponseType(typeof(ReservationDto), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> CreateReservation([FromBody] CreateResDto createDto)
        {
            if (createDto == null)
                return BadRequest("Invalid reservation data.");
            var roomExists = await _reservationRepo.CheckIfRoomExistsAsync(createDto.RoomId);
            if (!roomExists)
                return BadRequest("Room does not exist.");

            // Use repository to create the reservation
            var createdReservation = await _reservationRepo.CreateReservationAsync(
                createDto.RoomId,
                createDto.CheckInDate,
                createDto.CheckOutDate);

            if (createdReservation == null)
                return StatusCode(500, "Something went wrong while creating the reservation.");

            // Map the created reservation to a DTO
            var reservationDto = _mapper.Map<ReservationDto>(createdReservation);

            // Return the created reservation details
            return CreatedAtAction(nameof(GetReservationDetails), new { reservationId = reservationDto.ReservationId }, reservationDto);
        }



        // Update reservation details
        //[HttpPut]
        //[Route("Update/{reservationId}")]
        //public async Task<IActionResult> UpdateReservation([FromRoute] string reservationId, [FromBody] ReservationDto updatedDetails)
        //{
        //    bool result = await _reservationRepo.UpdateReservationAsync(reservationId, updatedDetails);
        //    if (!result)
        //        return NotFound("Reservation not found.");

        //    return NoContent(); // Status 204
        //}

        // Cancel a reservation
        [HttpPut]
        [Route("Cancel/{reservationId}")]
        public async Task<IActionResult> CancelReservation([FromRoute] string reservationId)
        {
            bool result = await _reservationRepo.CancelReservationAsync(reservationId);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // Confirm a reservation
        [HttpPut]
        [Route("Confirm/{reservationId}")]
        public async Task<IActionResult> ConfirmReservation([FromRoute] string reservationId)
        {
            bool result = await _reservationRepo.ConfirmReservationAsync(reservationId);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // Extend a reservation's checkout date
        [HttpPut]
        [Route("Extend/{reservationId}")]
        public async Task<IActionResult> ExtendReservation([FromRoute] string reservationId, [FromBody] DateTime newCheckOutDate)
        {
            bool result = await _reservationRepo.ExtendReservationAsync(reservationId, newCheckOutDate);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // Get reservation details by ID
        [HttpGet]
        [Route("{reservationId}")]
        public async Task<IActionResult> GetReservationDetails([FromRoute] string reservationId)
        {
            var reservation = await _reservationRepo.GetReservationDetailsAsync(reservationId);
            if (reservation == null)
                return NotFound("Reservation not found.");

            return Ok(reservation);
        }

        // Get all active reservations for a branch
        [HttpGet]
        [Route("Active/{branchId}")]
        public async Task<IActionResult> GetActiveReservations([FromRoute] int branchId)
        {
            var activeReservations = await _reservationRepo.GetActiveReservationsAsync(branchId);
            return Ok(activeReservations);
        }

        // Check in a reservation
        [HttpPut]
        [Route("CheckIn/{reservationId}")]
        public async Task<IActionResult> CheckIn([FromRoute] string reservationId)
        {
            bool result = await _reservationRepo.CheckInAsync(reservationId);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // Check out a reservation
        [HttpPut]
        [Route("CheckOut/{reservationId}")]
        public async Task<IActionResult> CheckOut([FromRoute] string reservationId)
        {
            bool result = await _reservationRepo.CheckOutAsync(reservationId);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // View reservation history for a customer
        [HttpGet]
        [Route("History/{customerId}")]
        public async Task<IActionResult> ViewReservationHistory([FromRoute] int customerId)
        {
            var reservationHistory = await _reservationRepo.ViewReservationHistoryAsync(customerId);
            return Ok(reservationHistory);
        }

        // Delete a reservation
        [HttpDelete]
        [Route("Delete/{reservationId}")]
        public async Task<IActionResult> DeleteReservation([FromRoute] string reservationId)
        {
            bool result = await _reservationRepo.DeleteReservationAsync(reservationId);
            if (!result)
                return NotFound("Reservation not found.");

            return NoContent(); // Status 204
        }

        // Calculate payment for a reservation
        [HttpGet]
        [Route("CalculatePayment/{reservationId}")]
        public async Task<IActionResult> CalculatePayment([FromRoute] string reservationId)
        {
            float paymentAmount = await _reservationRepo.CalculatePaymentAsync(reservationId);
            if (paymentAmount == 0)
                return NotFound("Reservation not found or invalid data.");

            return Ok(new { PaymentAmount = paymentAmount });
        }
    }

    // DTO for Reservation (used for creating and updating reservations)
    public class ReservationDto
    {
        public string ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
