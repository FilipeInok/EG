using Microsoft.AspNetCore.Mvc;
using Vinhos.Data;
using Vinhos.Models;

namespace Vinhos.Controllers
{
    public class RegioesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RegioesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Regioes> objRegioeslist = _db.Regioes;
            return View(objRegioeslist);
        }

    }
}
