using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class Employee : User
    {
        [Key]
        [ForeignKey("User")]
        public new int Id { get; set; } // Hide base Id to use as FK + PK

        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Position { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public string Gender { get; set; } = string.Empty;

        // Optional navigation property
        public virtual User User { get; set; }
    }
}
