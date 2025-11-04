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
    }
}
