using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class GenreController : Controller
    {
        BoolflixContext _context;
        public GenreController()
        {
            _context = new BoolflixContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View(genre);
            }
            _context.Genres.Add(genre);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e) {
                return NotFound(e.InnerException.Message);
            }
            return RedirectToAction("Genres", "Editor");
        }
        //update

        [HttpGet]
        public IActionResult Update(int id)
        {
            Feature feature = _context.Features.Find(id);
            return View(feature);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View(feature);
            }
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("Features", "Editor");
        }
        //delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Feature feature = _context.Features.Find(id);
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction("Features", "Editor");
        }
    }
}
