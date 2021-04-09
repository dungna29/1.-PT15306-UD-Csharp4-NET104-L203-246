using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_8_View.Models;

namespace Bai_8_View.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Create(SinhVienEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                message = "Sinh Viên: " + model.Ten + " Thêm mới thành công";
            }
            else
            {
                message = "Thêm thất bại";
            }
            return Content(message);
        }
    }
}
