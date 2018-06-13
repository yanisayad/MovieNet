using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNetModel.Interface;

namespace MovieNetModel.Dao
{
    public class MovieDao : IMovieDao
    {
        DataModelContainer dataModelContainer = new DataModelContainer();

        public Movie CreateMovie(Movie movie)
        {
            dataModelContainer.Movies.Add(movie);
            dataModelContainer.SaveChanges();

            return movie;
        }

        public bool DeleteMovie(Movie movie)
        {
            Movie movie_delete = dataModelContainer.Movies.Where(m => m.Id == movie.Id).FirstOrDefault();
            dataModelContainer.Movies.Remove(movie_delete);
            dataModelContainer.SaveChanges();

            return true;
        }

        public Movie UpdateMovie(Movie movie)
        {
            Movie update_movie = dataModelContainer.Movies.Where(m => m.Id == movie.Id).FirstOrDefault();
            update_movie.Title = movie.Title;
            update_movie.Description = movie.Description;
            update_movie.Duration = movie.Duration;

            if (update_movie.Equals(movie))
                dataModelContainer.SaveChanges(); 
            else
                throw new Exception("Update failed");

            Console.WriteLine("The movie is update.");

            return update_movie;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> all_movies = dataModelContainer.Movies.ToList();

            return all_movies;

        }

        public Movie GetMovie(int movie_id)
        {
            Movie movie = dataModelContainer.Movies.Where(m => m.Id == movie_id).FirstOrDefault();

            return movie;
        }
    }
}
