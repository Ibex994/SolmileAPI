using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolmileAPI.Models;

namespace Solmile.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int ContactId { get; set; }
        public virtual ICollection<RoomAssignment> RoomAssignments { get; set; }
        public virtual ICollection<ContactDetail> ContactDetails { get; set; }

    }
}
