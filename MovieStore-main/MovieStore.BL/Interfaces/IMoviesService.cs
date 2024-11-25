using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BL.Interfaces
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        void Add(Movie newMovie);

        void DeleteMovieById(int id);
    }
}
