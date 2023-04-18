using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAndBookStore.Data;
using MusicAndBookStore.Data.Repositories.IRepository;
using MusicAndBookStore.Entities;

namespace MusicAndBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ApplicationDbContext _context;
        public BookController(IBookRepository bookRepository, ApplicationDbContext context)
        {
            _bookRepository = bookRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpGet("Id")]
        public IActionResult Get(int id)
        {
            if(id == 0)
            {
                return BadRequest("Lütfen geçerli bir Id giriniz.");
            }

            var book = _bookRepository.GetById(id);
            return Ok(book);
        }

        [HttpPost("add")]
        public IActionResult Add(Book book)
        {
            _bookRepository.Add(book);
            return Ok(book);  
        }

        [HttpPatch("update")]
        public IActionResult Update(int productId,Book book)
        {
            if(productId == 0)
            {
                return BadRequest("Lütfen geçerli bir Id giriniz.");
            }

            _bookRepository.Update(book);

            return Ok("Güncelleme işlemi başarılı.");
        }

        [HttpDelete("Id")]
        public IActionResult Delete(int productId)
        {
            if (productId == 0)
            {
                return BadRequest("Lütfen geçerli bir Id giriniz.");
            }

            _bookRepository.Delete(productId);
            return NoContent();
        }
    }
}
