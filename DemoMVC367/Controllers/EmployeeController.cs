using Microsoft.AspNetCore.Mvc;

namespace DemoMVC367.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }
    }
}
