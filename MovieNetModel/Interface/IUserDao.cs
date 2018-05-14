using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    interface IUserDao
    {
        User CreateUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(User user);
    }
}
