using Microsoft.AspNetCore.Mvc;

namespace MANAOG_ITELEC_3ITE.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
