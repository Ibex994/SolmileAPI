using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        [Required]
        public string Password { get; set; } 
        public virtual Employee Employee { get; set; }
    }
    public class Resetpassword
    {
        public string username { get; set; } = string.Empty;
        public string oldpassword { get; set; } = string.Empty;
        public string newpassword { get; set; } = string.Empty;
    }
}
