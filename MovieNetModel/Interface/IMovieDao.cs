using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    public interface IMovieDao
    {
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        bool DeleteMovie(Movie movie);
        List<Movie> GetAllMovies();
        Movie GetMovie(int movie_id);
        List<Movie> SearchMovies(string name);
    }
}
