namespace SolmileGuesthouseAPI.Interface
{
    public interface IFileLogger
    {
        Task LogAsync(string message);
    }

}
