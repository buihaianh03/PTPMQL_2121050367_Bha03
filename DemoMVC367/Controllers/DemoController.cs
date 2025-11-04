using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.Identity.Client;

namespace DemoMVC367.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadFile()

        {
            var fileContent = Encoding.UTF8.GetBytes("Hello sir");
            var fileName = "example.txt";
            return File(fileContent, "text/plain", fileName);
        }
        public RedirectResult RedirectToFacebook()
        {
            return Redirect("https://www.facebook.com/");
        }
        public IActionResult GetJson()
        {
            var data = new
            {
                ID = 1,
                FullName = "Bui Hai Anh",
                Message = "Hello from DemoMVC367"
            };
            return Json(data);
        }
        public RedirectToActionResult GotoHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ErrorCode()
        {
            return StatusCode(404, "Resource not found");
        }
        public IActionResult SendToView()
        {
            string message = "Xin chao DemoMVC367";
            return View("Data", message);
        }
    
   public IActionResult DataExample()
        {
            ViewData["Message1"] = "Hello from Vietnam!";
            ViewBag.Message2 = "Hello from ViewBag!";
            TempData["City"] = "Ha Noi";

            return View();
        }

        public IActionResult TempDataExample()
        {
            var city = TempData["City"]?.ToString();
            ViewBag.CityName = city ?? "Unknown City";

            return View();
        }
    }
}
