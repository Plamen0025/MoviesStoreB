using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;


namespace MovieStore.BL.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetMovies();
        }
        public void Add(Movie newMovie)
        {
            _movieRepository.AddMovie(newMovie);
        }

        public void DeleteMovieById(int id)
        {
            _movieRepository.DeleteMovieById(id);   
        }
    }
}
