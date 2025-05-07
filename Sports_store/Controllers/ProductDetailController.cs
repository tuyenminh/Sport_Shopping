using Microsoft.AspNetCore.Mvc;

namespace Sports_store.Controllers
{
    public class ProductDetailController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
