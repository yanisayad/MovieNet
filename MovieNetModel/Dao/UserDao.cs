using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;

namespace MovieNetModel.Dao
{
    public class UserDao : IUserDao
    {
        DataModelContainer dataModelContainer = new DataModelContainer();
        public User CreateUser(User user)
        {
            //DataModelContainer dataModelContainer = new DataModelContainer();

            try
            {
                //DataModelContainer dataModelContainer = new DataModelContainer();
                dataModelContainer.Users.Add(user);
               
                dataModelContainer.SaveChanges();
                Console.Write("OK USER CREATE");
            }
            catch (Exception e)
            {
                Console.Write("VOILCI MON EXCEPTION : " + e);
            }

            return user;
            //throw new NotImplementedException();
        }

     /*   public List<User> GetAllUsers()
        {
            DataModelContainer dataModelContrainer = new DataModelContainer();

            dataModelContrainer.Users.ToList<User>;
        }@*/
    
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
