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
            _db.UFCD.Add(objUFCD);
            _db.SaveChanges();
            return View();
        }
    }
}
