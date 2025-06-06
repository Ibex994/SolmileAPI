namespace SolmileGuesthouseAPI.Helper
{
    public class SixDigitCode
    {
        public static string GenerateSixDigitCode()
        {
            var random = new Random();
            return random.Next(100000, 999999).ToString();
        }
    }
}
