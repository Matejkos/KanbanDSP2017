using Microsoft.AspNetCore.Mvc;

namespace KanbanDSP2017.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("../Index");
        }

        public IActionResult A()
        {
            return View("../Index","A kot ma ale");
        }
    }
}
