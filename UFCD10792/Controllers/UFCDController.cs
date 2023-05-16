using Microsoft.AspNetCore.Mvc;
using UFCD10792.Data;
using UFCD10792.Models;

namespace UFCD10792.Controllers
{
    public class UFCDController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UFCDController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<UFCD> objUFCDlist = _db.UFCD;
            return View(objUFCDlist);
        }
        //get
        public IActionResult Create()
        {
            return View();
        }
        //set(post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UFCD objUFCD)
        {
            if (objUFCD.name == objUFCD.code)
            {
                ModelState.AddModelError("name", "Name não pode ser igual ao Code");
            }
            if (ModelState.IsValid)
            {
                _db.UFCD.Add(objUFCD);
                _db.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(objUFCD);
        }
        //get
        public IActionResult Edit(int? id)
        {
            if (id<=0 || id == null)
            {
                return NotFound();
            }
            var UFCDFromDB = _db.UFCD.Find(id);
            var UFCDFromDBSOrD = _db.UFCD.SingleOrDefault(x => x.id == id);
            var UFCDFromDBSingle = _db.UFCD.Single(x => x.id == id);
            var UFCDFromDBFirstOrD = _db.UFCD.FirstOrDefault(x => x.id == id);
            return View(UFCDFromDB);
        }
        //set(post)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UFCD objUFCD)
        {
            if (objUFCD.name == objUFCD.code)
            {
                ModelState.AddModelError("name", "Name não pode ser igual ao Code");
            }
            if (ModelState.IsValid)
            {
                _db.UFCD.Add(objUFCD);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objUFCD);
        }
    }
}
