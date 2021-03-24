using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_8_View.Models;

namespace Bai_8_View.Controllers
{
    public class ViewBagViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Key Poly"] = "ViewData String";

            //ViewData kiểu đối tượng
            ViewData["GiaoVien"] = new GiaoVien()
            {
                MaGV = "dungna29",
                Ten = "Dũng",
                Email = "Dungna29@fe.edu.vn",
                Image = "/images/img1.jpg"
            };

            ViewBag.hello = "ViewBag String";

            ViewBag.GiaoVien = new GiaoVien()
            {
                MaGV = "dungna29",
                Ten = "Dũng",
                Email = "Dungna29@fe.edu.vn",
                Image = "/images/img1.jpg"
            };

            ViewData["poly"] = "ViewData String 2021";


            ViewData.Model = new GiaoVien()
            {
                MaGV = "dungna29",
                Ten = "Dũng1",
                Email = "Dungna29@fe.edu.vn",
                Image = "/images/img1.jpg"
            }; ;
            return View();
        }
    }
}
