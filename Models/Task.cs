using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class GuestHouseTask
    {
        [Key]
        public int TaskId { get; set; }
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignedTime { get; set; }
        public string Status { get; set; }
    }
}
