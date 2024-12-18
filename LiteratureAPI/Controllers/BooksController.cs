using LiteratureAPI.Models;
using LiteratureAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly BooksService _service;
        public BooksController(BooksService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var authors = _service.GetBooks();
            return Ok(authors); // return 200 OK with authors
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBooksById(int id)
        {
            var author = _service.GetBooks().FirstOrDefault(x => x.Id == id);
            return Ok(author); // return 200 OK with authors
        }

        [HttpPost]
        public IActionResult PostBook([FromBody] Book book)
        {
            _service.AddBook(book);
            return Created($"{Request.Path.Value}/{book.Id}",book);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            _service.RemoveBookById(id);
            return NoContent();
        }
    }
}
