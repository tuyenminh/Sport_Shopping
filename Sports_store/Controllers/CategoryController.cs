using Microsoft.AspNetCore.Mvc;

namespace Sports_store.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
