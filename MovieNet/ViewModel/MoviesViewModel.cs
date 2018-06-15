using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MovieNetModel;
using MovieNetModel.Service;
using MovieNetModel.Interface;
using MovieNetModel.Factory;


namespace MovieNet
{
    public class MoviesViewModel : ViewModelBase
    {
       /* List<Movie> AllMovies = new List<Movie>();
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public MoviesViewModel()
        {
            
        }

    */

        public MoviesViewModel()
        {
            Title = "";
            Duration = "";
            Description = "";
        }

        private string title;
        public string Title
        {
            get { return title; }
            set {
                title = value;
                RaisePropertyChanged();
            }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set {
                duration = value;
                RaisePropertyChanged();
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set {
                description = value;
                RaisePropertyChanged();
            }
        }

    
    }
}
