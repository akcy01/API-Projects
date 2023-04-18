using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Data;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicAlbumController : ControllerBase
    {
        private readonly IMusicAlbumRepository _musicAlbumRepository;
        private readonly ApplicationDbContext _context;
        public MusicAlbumController(IMusicAlbumRepository musicAlbumRepository, ApplicationDbContext context)
        {
            _musicAlbumRepository = musicAlbumRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _musicAlbumRepository.GetAll();
            return Ok(books);
        }

        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            var book = _musicAlbumRepository.GetById(id);
            return Ok(book);
        }

        [HttpPost("add")]
        public IActionResult Add(MusicAlbum musicAlbum)
        {
            _musicAlbumRepository.Add(musicAlbum);
            return Ok(musicAlbum);
        }

        [HttpPatch("update")]
        public IActionResult Update(int productId, MusicAlbum musicAlbum)
        {
            _musicAlbumRepository.Update(musicAlbum);
            return NoContent();
        }

        [HttpDelete("Id")]
        public IActionResult Delete(int productId)
        {
            _musicAlbumRepository.Delete(productId);
            return NoContent();
        }
    }
}
