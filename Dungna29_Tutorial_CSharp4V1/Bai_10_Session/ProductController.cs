using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_9.1_Session
{
    public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
