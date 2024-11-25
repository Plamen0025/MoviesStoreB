using Microsoft.Extensions.DependencyInjection;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore.DL
{
    public static class DependenciesInjection
    {
        public static IServiceCollection
            RegisterRepositories(this IServiceCollection services)
        {
            return services
                .AddSingleton<IMovieRepository, MovieRepository>()
                .AddSingleton<IActorRepository, ActorRepository>();
        }


    }
}
