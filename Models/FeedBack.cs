using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolmileAPI.Models;

namespace Solmile.Models
{
    public class FeedBack
    {
        public int FeedbackId { get; set; }
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Reservation Reservation { get; set; }
        public Customer Customer { get; set; }
    }
}
