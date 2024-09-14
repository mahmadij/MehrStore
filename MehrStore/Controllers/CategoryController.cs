using Microsoft.AspNetCore.Mvc;

namespace MehrStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Categories()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
    }
}
