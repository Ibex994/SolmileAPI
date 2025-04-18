using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class FeedBack
    {
        public int FeedbackId { get; set; }
        public string ReservationId { get; set; }
        public string CustomerId { get; set; }
        public string Details { get; set; }
        public int Rating { get; set; }
    }
}
