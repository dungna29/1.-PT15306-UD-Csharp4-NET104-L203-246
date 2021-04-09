using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_8_View.Models;

namespace Bai_8_View.Controllers
{
    public class GiaoVienController : Controller
    {
        public IActionResult Index()
        {
            var model = new ServiceGiaoVien();
            return View(model);
        }

        public IActionResult GetAllGV()
        {
            var model = new ServiceGiaoVien();
            return View(model);
        }
        public IActionResult AboutGV()
        {
            var model = new ServiceGiaoVien();
            return View(model);
        }
    }
}
