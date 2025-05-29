namespace SolmileGuesthouseAPI.Helper
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Example using BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
        }
    }
}
