using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Data;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ApplicationDbContext _context;
        public MovieController(IMovieRepository movieRepository, ApplicationDbContext context)
        {
            _movieRepository = movieRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _movieRepository.GetAll();
            return Ok(books);
        }

        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            if(id == 0)
            {
                return BadRequest("Geçersiz istekte bulundunuz.");
            }

            var book = _movieRepository.GetById(id);
            return Ok(book);
        }

        [HttpPost("add")]
        public IActionResult Add(Movie movie)
        {
            _movieRepository.Add(movie);
            return Ok(movie);
        }

        [HttpPatch("update")]
        public IActionResult Update(int productId, Movie movie)
        {
            _movieRepository.Update(movie);
            return NoContent();
        }

        [HttpDelete("Id")]
        public IActionResult Delete(int productId)
        {
            _movieRepository.Delete(productId);
            return NoContent();
        }
    }
}
