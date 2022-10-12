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
            List<Movie> movies = _context.Movies.ToList();
            return View(movies);
        }
        public IActionResult TvSeries()
        {
            return View();
        }
        public IActionResult Genres()
        {
            List<Genre> genres = _context.Genres.ToList();
            return View(genres);
        }

        //Features
        public IActionResult Features()
        {
            List<Feature> features = _context.Features.ToList();
            return View(features);
        }


        public IActionResult Actors()
        {
            List<Actor> actors = _context.Actors.ToList();
            return View(actors);
        }
    }
}
