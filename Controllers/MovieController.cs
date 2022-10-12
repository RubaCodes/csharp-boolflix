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
        public IActionResult Create()
        {
            MovieExtended movieEx = new MovieExtended();
            movieEx.Features = _context.Features.ToList();
            movieEx.Actors = _context.Actors.ToList();
            movieEx.Genres = _context.Genres.ToList();
            return View(movieEx);
        }
    }
}
