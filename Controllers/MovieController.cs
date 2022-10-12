using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class MovieController : Controller
    {
        BoolflixContext _context;
        public MovieController()
        {
            _context = new BoolflixContext();
        }
        [HttpGet]
        public IActionResult Create()
        {
            MovieExtended movieEx = new MovieExtended();
            movieEx.Features = _context.Features.ToList();
            movieEx.Actors = _context.Actors.ToList();
            movieEx.Genres = _context.Genres.ToList();
            return View(movieEx);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieExtended data)
        {
            if (!ModelState.IsValid)
            {
                data.Features = _context.Features.ToList();
                data.Actors = _context.Actors.ToList();
                data.Genres = _context.Genres.ToList();
                return View(data);
            }
            Movie movie = new Movie();
            //data.Features = _context.Features.Where(x => data.SelectedFeatures.Contains(x.Id)).toList();
            //data.Actors = _context.Actors.Where(x => data.SelectedActors.Contains(x.Id)).toList();
            return RedirectToAction("Movies", "Editor");
        }
    }
}
