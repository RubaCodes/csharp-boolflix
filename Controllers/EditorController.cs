using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        BoolflixContext _context;
        public EditorController() {
                _context = new BoolflixContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Movies()
        {
            return View();
        }
        public IActionResult TvSeries()
        {
            return View();
        }
        public IActionResult Genres()
        {
            return View();
        }

        //Features
        public IActionResult Features()
        {
            List<Feature> features = _context.Features.ToList();
            return View(features);
        }


        public IActionResult Actors()
        {
            return View();
        }
    }
}
