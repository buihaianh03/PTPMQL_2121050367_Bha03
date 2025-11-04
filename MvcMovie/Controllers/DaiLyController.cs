using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DaiLyController : Controller
    {
        public IActionResult Index()
        {
            var dailyList = new List<DaiLy>
            {
                new DaiLy { MaDaiLy = "DL01", TenDaiLy = "Đại Lý HaiEm", DiaChi = "Hà Nội", NguoiDaiDien = "Buihaianh", DienThoai = "0982911847", MaHTPP = "HT01" },
                new DaiLy { MaDaiLy = "DL02", TenDaiLy = "Đại Lý B", DiaChi = "Đà Nẵng", NguoiDaiDien = "Trần Thị B", DienThoai = "0987654321", MaHTPP = "HT02" }
            };

            return View(dailyList);
        }
    }
}
