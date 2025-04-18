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
        public User GetById(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }
        //public User GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public bool UserExist(int userId)
        {
            return _context.Users.Any(u=>u.Id == userId);
        }
    }
}
