using Microsoft.AspNetCore.Mvc;
using DemoMVC367.Models;

namespace DemoMVC367.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                return View("Details", student);
            }
            return View();
        }
    }
}
