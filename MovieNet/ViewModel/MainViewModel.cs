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
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows;

namespace MovieNet
{
    public class MainViewModel : ViewModelBase
    {
        User user   = new User();
        Frame OfficeView;
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public MainViewModel(Frame office)
        {
            Firstname = "";
            Lastname  = "";
            Login     = "";
            Password  = "";
            OfficeView = office;
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
            if (
               String.IsNullOrEmpty(Firstname) ||
               String.IsNullOrEmpty(Lastname) ||
               String.IsNullOrEmpty(Login) ||
               String.IsNullOrEmpty(Password)
           ){
                return;
            }

            serviceFacade.getUserDao().CreateUser(user);
        }

        bool CheckForm()
        {
            if (
                String.IsNullOrEmpty(Firstname) || 
                String.IsNullOrEmpty(Lastname) || 
                String.IsNullOrEmpty(Login) ||
                String.IsNullOrEmpty(Password) 
            )
            {
                return false;
            }
            return true;
        }

        void Connect()
        { 
            if (LoginToConnect != null && PasswordToConnect != null)
            {
                User UserConnect = serviceFacade.getUserDao().SearchUserToConnect(LoginToConnect, PasswordToConnect);
                Application.Current.Properties["UserConnect"] = UserConnect;
                
                if ((User)Application.Current.Properties["UserConnect"] != null)
                {
                    OfficeView.Content = new OfficeWindow();
                }
            }
        }
    }
       
}