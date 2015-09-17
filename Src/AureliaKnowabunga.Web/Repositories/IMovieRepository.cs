using System.Collections.Generic;
using AureliaKnowabunga.Web.Models;

namespace AureliaKnowabunga.Web.Repositories
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
    }

    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<Movie> GetAll()
        {
            return new[]
            {
                new Movie { Id = 1, Name = "Girlhood", ReleaseYear = 2015 },
                new Movie  { Id = 2, Name = "Montage of Heck", ReleaseYear = 2015 },
                new Movie { Id = 3, Name = "Inherent Vice", ReleaseYear = 2014 }
            };
        }
    }
}