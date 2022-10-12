using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FeatureController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create()
        {
            return View();
        }
    }
}
