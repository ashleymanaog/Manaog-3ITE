using Microsoft.AspNetCore.Mvc;

namespace ManaogMachProb1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
