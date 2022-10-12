using Microsoft.AspNetCore.Mvc;
//Controller esterno
namespace csharp_boolflix.Controllers
{
    
    public class ActorController : Controller
    {
        BoolflixContext _context;
        public ActorController() {
            _context = new BoolflixContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Actor actor)
        {
            if (!ModelState.IsValid) {
                return View(actor);
            }
            _context.Actors.Add(actor);
            _context.SaveChanges();
            return RedirectToAction("Actors","Editor");
        }
        //update

        [HttpGet]
        public IActionResult Update(int id)
        {
            Actor actor =_context.Actors.Find(id);
            return View(actor);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update( Actor actor)
        {
            if (!ModelState.IsValid) {
                return View(actor);
            }
            _context.Actors.Update(actor);
            _context.SaveChanges();
            return RedirectToAction("Actors","Editor");
        }
        //delete
        [HttpPost]
        public IActionResult Delete(int id){
            Actor actor = _context.Actors.Find(id);
            _context.Actors.Remove(actor);
            _context.SaveChanges();
            return RedirectToAction("Actors", "Editor");
        }
    }
}
