using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Bai_6_MVCWebApp.Models;
namespace Bai_6_MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Trả dữ liệu từ Controller về View
            var modelSV = new SinhVienUDPM();
            modelSV.tenSv = "SinhVien FPOLY";
            modelSV.des = "Chúng ta là sinh viên C#";
            return View(modelSV);
        }
    }
}
