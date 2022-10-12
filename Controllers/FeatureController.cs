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
        //update

                [HttpGet]
        public IActionResult Update(int id)
        {
            Feature feature =_context.Features.Find(id);
            return View(feature);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update( Feature feature)
        {
            if (!ModelState.IsValid) {
                return View(feature);
            }
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("Features","Editor");
        }
        //delete
        [HttpPost]
        public IActionResult Delete(int id){
            Feature feature = _context.Features.Find(id);
            _context.Features.Remove(feature);
            _context.SaveChanges();
            return RedirectToAction("Features", "Editor");
        }
    }
}
