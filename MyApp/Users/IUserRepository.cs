using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Users
{
    public interface IUserRepository
    {
        string GetUserName(int id);
    }
}
