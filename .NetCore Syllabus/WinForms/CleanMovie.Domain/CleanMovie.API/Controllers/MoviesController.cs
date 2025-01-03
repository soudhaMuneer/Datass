using CleanMovie.Application;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService movieService;
        public MoviesController(IMovieService _movieService)
        {
            movieService = _movieService;
        }
        [HttpGet]
        public ActionResult<List<Movie>> GetMovie()
        {
            var movies= movieService.GetAllMovies();
            return Ok();
        }
    }
}
