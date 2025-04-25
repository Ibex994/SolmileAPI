using API.Helper;
using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface userInterface
    {
        IQueryable<User> GetUsers();
        User GetById(int id);
        User GetByName(string name);
        bool UserExist(int userId);
        Task<bool> CreateUserAsync(User user);
        Task<bool> SaveAsync();
        Task<bool> Login(User user);
        Task<bool> Logout(int userId);
        Task<bool> LockAccount(int userId);
        Task<bool> UnlockAccount(int adminId, int userId);
        Task<bool> ResetStaffPassword(int staffId);
        Task<APIResponse> ResetPassword(string username, string oldpassword, string newpassword);
    }
}
