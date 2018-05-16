using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace MovieNet
{
    public class MainViewModel : ViewModelBase
    {
        private string _firstname;

        public MainViewModel()
        {
            Firstname = "Yanis";
            MyCommand = new RelayCommand(MyCommandExecute, MyCommandCanExecute);
        }

        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand MyCommand { get; }

        void MyCommandExecute()
        {
            if (Firstname != "Coucou Yanis")
                Firstname = "Coucou Yanis";
            else
                Firstname = "Yanis";

        }

        bool MyCommandCanExecute()
        {
            return true;
        }

    }
}
