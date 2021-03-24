using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAI_1_0_TaoDuAnMVC.Models;

namespace BAI_1_0_TaoDuAnMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var st1 = new Student("Dungna", "Học C#4 ở POLY");
            return View(st1);//Trả dữ liệu từ Controller về View
        }
        public IActionResult Student()
        {
            var svStudent = new ServiceStudent();
            return View(svStudent);
        }
    }
}
