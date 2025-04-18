using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
   public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int CustomerId { get; set; }

        [MaxLength(500)]
        public string RoomId { get; set; }

        public DateTime CheckOutDate { get; set; }
        public DateTime CheckInDate { get; set; }

        [MaxLength(500)]  
        public string Status { get; set; }

    }
}


