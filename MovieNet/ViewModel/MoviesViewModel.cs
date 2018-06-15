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
using System.Windows;
using GalaSoft.MvvmLight.CommandWpf;

namespace MovieNet
{
    public class MoviesViewModel : ViewModelBase
    {
        Movie movie = new Movie();
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public MoviesViewModel()
        {
            Title = "";
            Duration = "";
            Description = "";
            CreateMovie = new RelayCommand(Create, true);

        }

        //private string title;
        public string Title
        {
            get { return movie.Title; }
            set {
                movie.Title = value;
                RaisePropertyChanged();
            }
        }

        //private string duration;
        public string Duration
        {
            get { return movie.Duration; }
            set {
                movie.Duration = value;
                RaisePropertyChanged();
            }
        }

        //private string description;
        public string Description
        {
            get { return movie.Description; }
            set {
                movie.Description = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand CreateMovie { get; }

        void Create()
        {
            if (String.IsNullOrEmpty(Title) || String.IsNullOrEmpty(Duration) || String.IsNullOrEmpty(Description))
            {
                return;
            }
            movie.User = (User)Application.Current.Properties["UserConnect"];

            serviceFacade.getMovieDao().CreateMovie(movie);
        } 


    
    }
}
