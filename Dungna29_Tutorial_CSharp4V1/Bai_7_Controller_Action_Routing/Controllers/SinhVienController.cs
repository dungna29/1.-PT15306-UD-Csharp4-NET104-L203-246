using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_7_Controller_Action_Routing.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bai_7_Controller_Action_Routing.Controllers
{
    public class SinhVienController : Controller
    {
       
        //Url gốc: http://localhost:52478/sinhvien/editsv
        //Url edit: http://localhost:52478/sinhvien/suasinhvien

        //Cách 1
        //[ActionName("suasinhvien")]

        //Cách 2  tương tự sử dụng ActionName
        [Route("SinhVien/SuaSinhVien")]
        public string EditSV()
        {
            return "Action Method EditSV đổi thành suasinhvien";
        }

        [NonAction]
        public string DeleteSV()
        {
            return "Action Method DeleteSV";
        }

        public IActionResult Index()
        {
            // return RedirectToAction("Part1","GiaoVien");
            return Redirect("giao-vien/dungna29");
            //return StatusCode(200);
            //hoặc
            // return new StatusCodeResult(200);
        }





    }
}
