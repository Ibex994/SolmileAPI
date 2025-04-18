using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Solmile.Models
{
    public class Log
    {
        [Key]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Action { get; set; }         // e.g., "UserLogin"
        public string Message { get; set; }        // e.g., "Admin logged in"
        public LogLevel Level { get; set; }        // Info, Warning, Error
        public string User { get; set; }          // Optional: Associated user
    }
    public enum LogLevel { Info, Warning, Error }
}
