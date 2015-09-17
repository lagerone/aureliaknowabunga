using System.Collections.Generic;
using System.Web.Http;
using AureliaKnowabunga.Web.Models;

namespace AureliaKnowabunga.Web.Api
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
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