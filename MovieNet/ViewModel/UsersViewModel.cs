using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MovieNetModel;
using MovieNetModel.Service;
using MovieNetModel.Factory;
using MovieNetModel.Interface;

namespace MovieNet
{
    public class UsersViewModel : ViewModelBase
    {
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public UsersViewModel()
        {
            Users = serviceFacade.getUserDao().GetAllUsers();
            SelectItem = new User();
            
            Firstname = "";
            Lastname = "";
            Password = "";

            Update = new RelayCommand(UpdateUser, true);
            Delete = new RelayCommand(DeleteUser, true);
        }


        private List<User> users;
        public List<User> Users
        {
            get { return users; }
            set {
                users = value;
                RaisePropertyChanged();
            }
        }

        private User select_item;
        public User SelectItem
        {
            get { return select_item; }
            set {
                select_item = value;
                RaisePropertyChanged();
            }
        }

        private string firstname;
        public string Firstname
        {
            get { return SelectItem.Firstname; }
            set {
                firstname = value;
                RaisePropertyChanged();

            }
        }

        private string lastname;
        public string Lastname
        {
            get { return SelectItem.Lastname; }
            set
            {
                lastname = value;
                RaisePropertyChanged();

            }
        }

        private string password;
        public string Password
        {
            get {
                return SelectItem.Password; }
            set
            {
               password = value;
                RaisePropertyChanged();

            }
        }


        public RelayCommand Update { get; }
        public RelayCommand Delete { get; }
        
        void UpdateUser()
        {
            Console.WriteLine(SelectItem);
            serviceFacade.getUserDao().UpdateUser(SelectItem);
        }

        void DeleteUser()
        {
            Console.WriteLine(SelectItem);
            serviceFacade.getUserDao().DeleteUser(SelectItem);
            Users = serviceFacade.getUserDao().GetAllUsers();
        }

    }
}
