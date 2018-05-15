using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;
using MovieNetModel.Factory;
using MovieNetModel.Service;

namespace MovieNetModel
{
    public class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            ServiceFacade serviceFacade = new ServiceFacade();


            user.Firstname = "Yanis";
            user.Lastname = "AYAD";
            user.Login = "ayad_y";

            serviceFacade.getUserDao().CreateUser(user);


        }
            

    }
}
