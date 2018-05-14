using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNetModel.Interface
{
    interface IMovieDao
    {
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        bool DeleteMovie(Movie movie);
    }
}
