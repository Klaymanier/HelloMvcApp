using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApp.Controllers
{
    public class SnakeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
