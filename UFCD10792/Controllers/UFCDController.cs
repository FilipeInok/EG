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

    }
}
