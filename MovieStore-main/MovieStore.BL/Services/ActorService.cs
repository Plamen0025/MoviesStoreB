using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.BL.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

       public Actor GetActorById(int id)
        {
           return _actorRepository.GetActorById(id);
        }

        public List<Actor> GetActors()
        {
            return _actorRepository.GetActors();
        }
    }
}
