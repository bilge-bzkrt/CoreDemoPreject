using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult actionResult()
        {
            return View();
        }
    }
}
