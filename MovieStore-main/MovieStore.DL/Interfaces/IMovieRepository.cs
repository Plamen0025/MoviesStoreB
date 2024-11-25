using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Models.DTO;


namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetMovies();
        void AddMovie(Movie newMovie);

        void DeleteMovieById(int id);
    }
}
