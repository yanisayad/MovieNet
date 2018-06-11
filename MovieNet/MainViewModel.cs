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
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public MainViewModel()
        {
            Firstname = "";
            Lastname  = "";
            Login     = "";
            Password  = "";
            //LoginToConnect = "";
            //PasswordToConnect = "";
            MyCommand = new RelayCommand(CreateUser, true);
            Connexion = new RelayCommand(Connect, true);

        }

        private string login_connect;
        public string LoginToConnect
        {
            get { return login_connect; }
            set
            {
                login_connect = value;
                RaisePropertyChanged();
            }
        }

        private string password_connect;
        public string PasswordToConnect
        {
            get { return password_connect; }
            set
            {
                password_connect = value;
                RaisePropertyChanged();
            }
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
        public RelayCommand Connexion { get; }

        void CreateUser()
        {
            serviceFacade.getUserDao().CreateUser(user);                               
        }

        void Connect()
        { 
            Console.Write("Voici mon login" + LoginToConnect);
            Console.Write("Voici mon pwd" + PasswordToConnect);


            serviceFacade.getUserDao().SearchUserToConnect(LoginToConnect, PasswordToConnect);
        }
    }
}
