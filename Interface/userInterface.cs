using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface userInterface
    {
        ICollection<User> GetUsers();
        User GetById(int id);
        User GetByName(string name);
        bool UserExist(int userId);
    }
}
