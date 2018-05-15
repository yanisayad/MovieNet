using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;

namespace MovieNetModel.Dao
{
    class UserDao : IUserDao
    {
        public User CreateUser(User user)
        {
            DataModelContainer dataModelContainer = new DataModelContainer();

            try
            {
                dataModelContainer.Users.Add(user);

                dataModelContainer.SaveChanges();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            return user;
            //throw new NotImplementedException();
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
