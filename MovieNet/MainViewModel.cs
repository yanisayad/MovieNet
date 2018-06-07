using System;
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
    public class MainViewModel : ViewModelBase
    {
        User user = new User();

        public MainViewModel()
        {
            Firstname = "Prénom";
            Lastname  = "Nom";
            Login     = "Login";
            Password  = "Mot de passe";
            MyCommand = new RelayCommand(CreateUser, true);
        }


        public string Firstname
        {
            get { return user.Firstname; }
            set
            {
                user.Firstname = value;
                RaisePropertyChanged();
            }
        }

        public string Lastname
        {
            get { return user.Lastname; }
            set
            {
                user.Lastname = value;
                RaisePropertyChanged();
            }
        }

        public string Login
        {
            get { return user.Login; }
            set
            {
                user.Login = value;
                RaisePropertyChanged();
            }
        }

        public string Password
        {
            get { return user.Password; }
            set
            {
                user.Password = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand MyCommand { get; }

        void CreateUser()
        {
            IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

            serviceFacade.getUserDao().CreateUser(user);
                               
        }

    }
}
