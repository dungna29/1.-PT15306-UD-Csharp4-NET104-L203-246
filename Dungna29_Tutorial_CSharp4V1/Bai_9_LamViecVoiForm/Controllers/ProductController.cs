using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_9_LamViecVoiForm.Models;

namespace Bai_9_LamViecVoiForm.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]//DÙng để hiển thị ra form Create
        public IActionResult Create()
        {
            return View();
        }
        /*
        * Phương thức thứ 2 sẽ nhận vào 1 cái model nếu truyền đúng dữ liệu hợp lệ thì sẽ thông báo thành công và ngược lại.
        */
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string mess = String.Empty;
            if (ModelState.IsValid)//Nếu Model truyền vào hợp lệ
            {
                mess = "ID-Product: " + model.Id + " .Name" +
                       model.Name + " Rate: " + model.Rate +
                       " Rating: " + model.Rating + " Tạo mới thành công";
                //Nếu tạo thành công thì sẽ đẩy ra 1 thông báo
            }
            else
            {
                mess = "Tạo không thành công hãy làm lại";
            }
            return Content(mess);
        }
    }
}
