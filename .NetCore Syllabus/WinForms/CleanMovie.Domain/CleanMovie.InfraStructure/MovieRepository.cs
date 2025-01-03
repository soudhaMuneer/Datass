using CleanMovie.Application;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.InfraStructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movie =
        [
            new Movie
            {
                id= 1,Name="murukan",Cost=2
            },
            new Movie
            {
                id= 2,Name="mu",Cost=2
            }
        ];
     
        public List<Movie> GetAllMovies()
        {
            return movie;
        }
    }
}
