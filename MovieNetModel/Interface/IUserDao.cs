using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    public interface IUserDao
    {
        User CreateUser(User user);
      //  User getUser();
        //List<User> GetAllUsers();
        User UpdateUser(User user);
        bool DeleteUser(User user);
    }
}
