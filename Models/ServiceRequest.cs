using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class ServiceRequest
    {
        [Key]
        public int RequestId { get; set; }
        public string RequestedBy { get; set; }
        public string RequestorId { get; set; }
        public int ServiceTypeId { get; set; }
        public string Location { get; set; }
        public DateTime RequiredByDateTime { get; set; } // Replaced LocalDateTime with DateTime
        public string Status { get; set; }
        public string ExtraDetail { get; set; }
        public string AttachPhoto { get; set; } // Replaced Uri with string for file path or URL

      
       
    }
}
