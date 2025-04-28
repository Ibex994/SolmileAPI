using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int ContactId { get; set; }
        public virtual ICollection<RoomAssignment> RoomAssignments { get; set; }

    }
}
