using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BL.Interfaces
{
    public interface IActorService
    {
        List<Actor> GetActors();

        Actor GetActorById(int id);
    }
}
