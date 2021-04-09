using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_7_Controller_Action_Routing.Models;

namespace Bai_7_Controller_Action_Routing.Controllers
{
    //[Route("giao-vien")]//Khi khai báo thế này thì đã vào được đây thì phải có giao-vien trên url
    public class GiaoVienController : Controller
    {
        //Attribute Routing

        //[Route("")]//Nếu trong trường hợp url rỗng sẽ vào action dưới đây
        //[Route("full")]
        //[ActionName("dungna29")]
        public string Full()
        {
            var model = new TestGiaoVien();
            return "Giáo viên full time";
        }

        //[Route("part/{id?}")]
        public string Part(int id)
        {
            var model = new TestGiaoVien();
            return "Giáo viên part time với ID = " + id;
        }

        public string Part1()
        {
            return "Part1";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            ViewData["Key Dungna"] ="Đây là string từ viewdata Contronller";
            ViewData["GiaoVien"] = new GiaoVien()
            {
                MaGV = "dungna29",
                Ten = "Dũng",
                Email = "Dungna29@fe.edu.vn",
                Image = "/images/img1.jpg"
            };

            ViewBag.DungnaPoly = null;
            return View();
        }
    }
}
