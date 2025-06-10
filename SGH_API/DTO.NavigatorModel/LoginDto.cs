using SolmileGuesthouseAPI.Data.Models;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuesthouseAPI.DTO.NavigatorModel
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class UserLoginResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public EmployeeDto Employee { get; set; }
    }
    public class VerifyOtpDto
    {
        public string Username { get; set; }
        public string Code { get; set; }
    }

}
