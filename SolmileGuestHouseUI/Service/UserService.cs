using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BCrypt.Net;
using Solmile.Interface;

namespace Solmile.Service
{

    public class UserService : IUserService
    {
        //    public bool Login(string username, string password)
        //    {
        //        using (var context = new DataContext())
        //        {

        //            var user = context.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

        //            if (user == null)
        //            {

        //                return false;
        //            }


        //            bool isPasswordValid = (user.Password == password);

        //            return isPasswordValid;
        //        }
        //}
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
