using Microsoft.AspNetCore.Mvc;

namespace LiteratureAPI.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
