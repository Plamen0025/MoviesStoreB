using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DL.DB
{
    internal class StaticData
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "The Shawshank Redemption", Year = 1994 },
            new Movie { Id = 2, Title = "The Godfather", Year = 1972 },
            new Movie { Id = 3, Title = "The Dark Knight", Year = 2008 },
            new Movie { Id = 4, Title = "Arcane", Year = 2024 }
        };

        public static List<Actor> Actors=new List<Actor> 
        { 
            new Actor { Id = 1, Name="Ivan" },
            new Actor { Id = 2, Name="Hristo" },
            new Actor { Id = 3,Name="Georgi" }

        };
    }
}
