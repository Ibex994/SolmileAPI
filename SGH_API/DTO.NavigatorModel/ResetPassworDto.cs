using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class ResetPasswordDto
    {
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public string NewPassword { get; set; }
    }
    public class ForgotPasswordRequestDto
    {
        public string Username { get; set; }
    }

    public class ResetPasswordWithCodeDto
    {
        public string Username { get; set; }

        public string Code { get; set; } = string.Empty;

        public string NewPassword { get; set; } = string.Empty;
    }
    public class ChangePasswordDto
    {
        public string Username { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
