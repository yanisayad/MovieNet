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
            dataModelContainer.Users.Add(user);
               
            dataModelContainer.SaveChanges();
            Console.Write("OK USER CREATE");

            return user;
        }

        public bool DeleteUser(User user)
        {
            User delete_user = dataModelContainer.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            dataModelContainer.Users.Remove(delete_user);
            dataModelContainer.SaveChanges();
            return true;
        }

        public User UpdateUser(User user)
        {
            User update_user = dataModelContainer.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            update_user.Firstname = user.Firstname;
            update_user.Lastname = user.Lastname;
            update_user.Login = user.Login;
            update_user.Password = user.Password;

            if (update_user.Equals(user))
            {
                Console.WriteLine("The user is update.");
                dataModelContainer.SaveChanges();
                return update_user;
            }
            else
            {
                throw new Exception("Update failed");
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> all_users = dataModelContainer.Users.ToList();
            return all_users;
        }

        public User getUser(int user_id)
        {
            User user = dataModelContainer.Users.Where(u => u.Id == user_id).FirstOrDefault();
            return user;
        }


        public void SearchUserToConnect(string login, string password)
        {

            var query = dataModelContainer.Users.Where(u => u.Login.Equals(login)).Where(u => u.Password.Equals(password)).ToList();

            dataModelContainer.SaveChanges();
 
        }
    }
}
