using System.ComponentModel.DataAnnotations;

namespace SolmileAPI.DTO
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public string RoomId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }
    }

    public class CreateResDto
    {
        public string RoomId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
    }
}
