using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MovieNetModel;

namespace MovieNet
{
    class VM_mainWindow : ViewModelBase
    {
        private ObservableCollection<User> _users;
         

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public VM_mainWindow()
        {

        }

    }
}
