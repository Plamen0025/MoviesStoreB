using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        List<Actor> GetActors();

        Actor GetActorById(int id);
    }
}
