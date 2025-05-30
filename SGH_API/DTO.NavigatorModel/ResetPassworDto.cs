using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class ResetPassworDto
    {
        public string Username { get; set; }
        [Required]
        public string Token { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string NewPassword { get; set; } = string.Empty;
    }
}
