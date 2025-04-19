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

        public async Task<bool> SaveAsync()
        {
            var saved = await _context.SaveChangesAsync();
            return saved > 0;
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
