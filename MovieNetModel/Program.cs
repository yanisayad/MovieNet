using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel
{
    public class Program
    {

        static void Main(string[] args)
        {

            DataModelContainer ctx = new DataModelContainer();

            User user = new User();

            user.Firstname = "Yanis";
            user.Lastname  = "AYAD";
            user.Login     = "ayad_y";

            try
            {
                ctx.Users.Add(user);

                ctx.SaveChanges();
            }
            catch (Exception e)
            {

                Console.Write("coucou");
            }
            
        }

        

    }
}
