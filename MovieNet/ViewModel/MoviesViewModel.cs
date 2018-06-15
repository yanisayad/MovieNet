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
        Comment comment = new Comment();
        IServiceFacade serviceFacade = ServiceFacadeFactory.getServiceFacade();

        public MoviesViewModel()
        {
            Title = "";
            Duration = "";
            Description = "";
            CreateMovie = new RelayCommand(Create, true);
            UpdateMovie = new RelayCommand(Update, true);
            DeleteMovie = new RelayCommand(Delete, true);
            SearchMovie = new RelayCommand(Search, true);
            ResetSearch = new RelayCommand(Reset, true);

            CreateComment = new RelayCommand(CommentCreate, true);

            Movies = serviceFacade.getMovieDao().GetAllMovies();
            SelectItem = new Movie();

            Comments = serviceFacade.getCommentDao().GetAllComments();

        }

        private List<Movie> movies;
        public List<Movie> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
                RaisePropertyChanged();
            }
        }

        private Movie select_item;
        public Movie SelectItem
        {
            get { return select_item; }
            set
            {
                select_item = value;
                RaisePropertyChanged();
            }
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
        public RelayCommand UpdateMovie { get; }
        public RelayCommand DeleteMovie { get; }

        void Create()
        {
            if (String.IsNullOrEmpty(Title) || String.IsNullOrEmpty(Duration) || String.IsNullOrEmpty(Description))
            {
                return;
            }
            movie.User = (User)Application.Current.Properties["UserConnect"];

            serviceFacade.getMovieDao().CreateMovie(movie);
            Movies = serviceFacade.getMovieDao().GetAllMovies();
        }

        void Update()
        {
            serviceFacade.getMovieDao().UpdateMovie(SelectItem);
            Movies = serviceFacade.getMovieDao().GetAllMovies();
        }

        void Delete()
        {
            serviceFacade.getMovieDao().DeleteMovie(SelectItem);
            Movies = serviceFacade.getMovieDao().GetAllMovies();
        }


        public RelayCommand CreateComment { get; }

        //  private string comment_title;



        private List<Comment> comments;
        public List<Comment> Comments
        {
            get { return comments; }
            set
            {
                comments = value;
                RaisePropertyChanged();
            }
        } 

        public string CommentTitle
        {
            get { return comment.Title; }
            set {
                comment.Title = value;
                RaisePropertyChanged();
            }
        }

//        private string comment_content;

        public string CommentContent
        {
            get { return comment.Content; }
            set {
                comment.Content = value;
                RaisePropertyChanged();

            }
        }


        void CommentCreate()
        {
            comment.User = (User)Application.Current.Properties["UserConnect"];
            comment.Movie = SelectItem;
            serviceFacade.getCommentDao().CreateComment(comment);
            SelectItem.Comments = serviceFacade.getCommentDao().GetAllComments();
        }

        public RelayCommand SearchMovie { get; }
        public RelayCommand ResetSearch { get; }

        private string name_to_search;
        public string NameToSearch
        {
            get { return name_to_search; }
            set {
                name_to_search = value;
                RaisePropertyChanged();
            }
        }

        void Search()
        {
            Movies = serviceFacade.getMovieDao().SearchMovies(NameToSearch);
        } 

        void Reset()
        {
            Movies = serviceFacade.getMovieDao().GetAllMovies();
            NameToSearch = "";
        }
    }
}
