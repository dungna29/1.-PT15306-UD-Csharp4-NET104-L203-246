using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.ResponseCaching.Internal;

namespace BAI_1_0_TaoDuAnMVC.Controllers
{
    // [Route("fpoly2020")]
    public class FpolyController : Controller
    {
        // [Route("")]
        // [Route("svweb/{a?}")]
        // [Route("svweb")]
        //[ActionName("svweb")] Chỉ đổi tên url của Action Method
        public string SinhVienWeb(string id)
        {
            return "Số trên URL = " + id;
        }
        // [Route("svud")]
        public IActionResult SinhVienUD()
        {
            return View();
        }

        [NonAction]
        public string EditSV()
        {
            return "Sửa sinh viên";
        }
    }
}
