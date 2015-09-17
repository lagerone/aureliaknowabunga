using System.Collections.Generic;
using System.Web.Http;
using AureliaKnowabunga.Web.Models;
using AureliaKnowabunga.Web.Repositories;

namespace AureliaKnowabunga.Web.Api
{
    public class MoviesController : ApiController
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movie> Get()
        {
            return _movieRepository.GetAll();
        }
    }
}