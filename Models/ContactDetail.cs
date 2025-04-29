using System.ComponentModel.DataAnnotations;
using Solmile.Models;

namespace SolmileAPI.Models
{
    public class ContactDetail
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        public string EmergencyContact { get; set; }

        [Required]
        public string ContactType { get; set; }
        public int? BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
