using LiteratureAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiteratureAPI.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly AuthorsService _service;
        public AuthorsController(AuthorsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _service.GetAuthors();
            return Ok(authors); // return 200 OK with authors
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAuthorsById(int id)
        {
            var author = _service.GetAuthors().FirstOrDefault(x => x.Id == id);
            return Ok(author); // return 200 OK with authors
        }
    }
}
