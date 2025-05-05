using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class EmployeeTask
    {
        [Key]
        public int TaskId { get; set; }
        public int RequestId { get; set; }
        public int? EmployeeId { get; set; }
        public string TaskDetails { get; set; }

        [DataType(DataType.Date)]
        public DateTime AssignedTime { get; set; } = DateTime.UtcNow;
        public string Status { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
