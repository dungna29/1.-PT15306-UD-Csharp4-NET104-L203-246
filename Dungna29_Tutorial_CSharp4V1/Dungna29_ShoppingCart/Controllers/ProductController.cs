using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungna29_ShoppingCart.ViewModels;

namespace Dungna29_ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        private ServiceProduct _serviceProduct = new ServiceProduct();

        public IActionResult Index()
        {
            ViewBag.product = _serviceProduct.FakeDataProducts();
            return View();
        }
    }
}
