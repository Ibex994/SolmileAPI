namespace SolmileGuesthouseAPI.Data.Models
{
    public class TokenResponse
    {
            public string Token { get; set; } = string.Empty;
            public string RefreshToken { get; set; } = string.Empty;
            public string UserRole { get; set; } = string.Empty;
        }
}

