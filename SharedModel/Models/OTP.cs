using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class OTP
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Reason { get; set; } 

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiryAt { get; set; }

        public bool IsUsed { get; set; } = false;
        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpiryAt { get; set; }
        public bool ResetTokenUsed { get; set; }
    }
}
