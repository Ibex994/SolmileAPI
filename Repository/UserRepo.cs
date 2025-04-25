using API.Helper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class UserRepo : userInterface
    {
        private readonly DataContext _context;

        public UserRepo(DataContext context)
        {
            _context = context;
        }

        public Task<bool> CreateUserAsync(User user)
        {
            _context.AddAsync(user);
            return SaveAsync();
        }

        public User GetById(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }
        public User GetByName(string name)
        {
           return _context.Users.Where(u => u.Username == name).FirstOrDefault();
        }

        public async Task<bool> LockAccount(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            user.IsLocked = true;
            return await SaveAsync();
        }

        public async Task<bool> Login(User user)
        {
            return await _context.Users.Include(a => a.Employee).AnyAsync(u => u.Username == user.Username && u.Password == user.Password);
        }

        public async Task<bool> Logout(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            return user != null;
        }

        public async Task<APIResponse> ResetPassword(string username, string oldpassword, string newpassword)
        {
            var user = await _context.Employees
                .FirstOrDefaultAsync(e => e.Username == username && e.Password == oldpassword && e.Status == true);

            if (user == null)
            {
                return new APIResponse
                {
                    ResponseCode = 400,
                    Result = "Failed",
                    Message = "Failed to validate old password or user not active."
                };
            }

            user.Password = newpassword;
            await _context.SaveChangesAsync();

            return new APIResponse
            {
                ResponseCode = 200,
                Result = "Success",
                Message = "Password has been reset successfully."
            };
        }

        public async Task<bool> ResetStaffPassword(int staffId)
        {
            var user = await _context.Users.FindAsync(staffId);
            if (user == null) return false;

            user.Password = "Default@123";
            return await SaveAsync();
        }

        public async Task<bool> SaveAsync()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
        }

        public async Task<bool> UnlockAccount(int adminId, int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            user.IsLocked = false;
            return await SaveAsync();
        }

        public bool UserExist(int userId)
        {
            return _context.Users.Any(u=>u.Id == userId);
        }

        IQueryable<User> userInterface.GetUsers()
        {
            return _context.Users.AsQueryable();
        }
    }
}
