using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using System.Collections;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
           _actorService = actorService;
        }

        [HttpGet("GetAllActors")]
        public IEnumerable<Actor> GetActors()
        {
            return _actorService.GetActors();
        }

        [HttpGet("{id}")]
        public Actor GetActorById(int id)
        {
            return _actorService.GetActorById(id);
        }


    }
}
