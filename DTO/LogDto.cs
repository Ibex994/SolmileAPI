using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.DTO
{
    public class LogDto
    {
        public int LogId { get; set; }
        public string Action { get; set; }
        public string Level { get; set; }
        public int? PerformedBy { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
