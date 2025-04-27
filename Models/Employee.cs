using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SolmileAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solmile.Models
{
    public class Employee : User
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Position { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public string Gender { get; set; } = string.Empty;
        public virtual User User { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
    }
}
