using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_7_Controller_Action_Routing.Models;

namespace Bai_7_Controller_Action_Routing.Controllers
{
    [Route("giao-vien")]//Khi khai báo thế này thì đã vào được đây thì phải có giao-vien trên url
    public class GiaoVienController : Controller
    {
        //Attribute Routing

        [Route("")]//Nếu trong trường hợp url rỗng sẽ vào action dưới đây
        [Route("full")]
        public string Full()
        {
            var model = new TestGiaoVien();
            return "Giáo viên full time";
        }

        [Route("part/{id?}")]
        public string Part(int id)
        {
            var model = new TestGiaoVien();
            return "Giáo viên part time với ID = " + id;
        }
    }
}
