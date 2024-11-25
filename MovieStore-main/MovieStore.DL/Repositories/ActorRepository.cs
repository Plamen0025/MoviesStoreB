using MovieStore.DL.DB;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DL.Repositories
{
    public class ActorRepository : IActorRepository
    {
        public Actor? GetActorById(int id)
        {
            return StaticData.Actors.FirstOrDefault(actor => actor.Id == id);
        }

        public List<Actor> GetActors()
        {
            return StaticData.Actors;
        }
    }
}
