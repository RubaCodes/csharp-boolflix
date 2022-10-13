using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            Movie newMovie = new Movie();
            newMovie = data.Movie;
            data.Movie.MediaInfo.Features = _context.Features.Where(x => data.SelectedFeatures.Contains(x.Id)).ToList();
            data.Movie.MediaInfo.Cast = _context.Actors.Where(act => data.SelectedActors.Contains(act.Id)).ToList();
            data.Movie.MediaInfo.Genres = _context.Genres.Where(gen => data.SelectedGenres.Contains(gen.Id)).ToList();
            newMovie.MediaInfo = data.MediaInfo;
            _context.Movies.Add(newMovie);
            //_context.MediaInfos.Add(newMovie.MediaInfo);
            _context.SaveChanges();
            return RedirectToAction("Movies", "Editor");
        }
    }
}
