using MovieStore.DL.DB;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
        public void AddMovie(Movie newMovie)
        {
            newMovie.Id = StaticData.Movies.Count > 0 ? StaticData.Movies[^1].Id + 1 : 1;
            StaticData.Movies.Add(newMovie);
        }

        public void DeleteMovieById(int id)
        {
            
            var movie = StaticData.Movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                StaticData.Movies.Remove(movie);
            }
        }
    }
}
