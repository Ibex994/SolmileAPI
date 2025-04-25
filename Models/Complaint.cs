using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolmileAPI.Models;

namespace Solmile.Models
{
    public class Complaint
    {
        public int ComplaintId { get; set; }
        public  string Details { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
