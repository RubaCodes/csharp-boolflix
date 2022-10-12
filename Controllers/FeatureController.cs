using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    
    public class FeatureController : Controller
    {
        BoolflixContext _context;
        public FeatureController() {
            _context = new BoolflixContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Feature feature)
        {
            if (!ModelState.IsValid) {
                return View(feature);
            }
            _context.Features.Add(feature);
            _context.SaveChanges();
            return RedirectToAction("Features","Editor");
        }
    }
}
