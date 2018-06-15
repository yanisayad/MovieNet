﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MovieNetModel.Interface;
using MovieNetModel.Factory;
using MovieNetModel.Service;
using MovieNetModel;

namespace MovieNet
{
    public class AuthenticationService : ViewModelBase
    {
        public User UserConnected;             

        void SetCookieUser(User user) 
        {
            UserConnected = user;
        } 

        User GetCookieUser()
        {
            return UserConnected;
        }

        void ResetCookieUser()
        {
            UserConnected = new User();
        }
    }
}
