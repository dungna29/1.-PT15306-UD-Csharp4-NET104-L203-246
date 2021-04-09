using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai_7_Controller_Action_Routing.Models;

namespace Bai_7_Controller_Action_Routing.Controllers
{
    public class HomeController : Controller
    {
        //[Route("trangchu/{temp:int}")]
        public IActionResult Index(int temp)
        {
            var model = new TestModel();
            model.Message = "Home index ID = " + temp;
            return View(model);
        }
    }
}
