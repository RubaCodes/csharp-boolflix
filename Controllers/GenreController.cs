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
            }// legge lo unique solo al bd
            catch (Exception e) {
                return View(genre);
            }
            return RedirectToAction("Genres", "Editor");
        }
        //update

        [HttpGet]
        public IActionResult Update(int id)
        {
            Genre genre = _context.Genres.Find(id);
            return View(genre);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update( Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View(genre);
            }
            _context.Genres.Update(genre);
            _context.SaveChanges();
            return RedirectToAction("Genres", "Editor");
        }
        //delete
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Genre genre= _context.Genres.Find(id);
            _context.Genres.Remove(genre);
            _context.SaveChanges();
            return RedirectToAction("Genres", "Editor");
        }
    }
}
