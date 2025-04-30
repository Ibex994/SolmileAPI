using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolmileAPI.Models;

namespace Solmile.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int CustomerId { get; set; } 
        public int? PaymentId { get; set; } 
        public string RoomId { get; set; }    

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        // Navigation Properties
        public virtual Customer Customer { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Room Room { get; set; }
        public ICollection<FeedBack> Feedbacks { get; set; }
    }
}


