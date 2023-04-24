using Microsoft.AspNetCore.Mvc;

namespace UFCD10792.Controllers
{
    public class UFCDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
