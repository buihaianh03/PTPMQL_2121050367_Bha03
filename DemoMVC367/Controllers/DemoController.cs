using System.Text;
using Microsoft.AspNetCore.Mvc;

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
    }
}