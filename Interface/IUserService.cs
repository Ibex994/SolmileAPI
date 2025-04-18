using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Interface
{
    public interface IUserService
    {
        bool Login(string username, string password);
    }
}
