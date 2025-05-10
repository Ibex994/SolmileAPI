using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        [ForeignKey("ContactDetails")]
        public int ContactId { get; set; }
        public ContactDetails ContactDetails { get; set; }

        // Navigation properties
        public ICollection<RoomNumberAssignment> RoomNumberAssignments { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}