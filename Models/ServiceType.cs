using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class ServiceType
    {
        [Key]
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

    }
}
