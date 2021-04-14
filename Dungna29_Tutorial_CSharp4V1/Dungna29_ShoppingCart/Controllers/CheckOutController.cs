using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dungna29_ShoppingCart.Models;
using Dungna29_ShoppingCart.Utilities;

namespace Dungna29_ShoppingCart.Controllers
{
    public class CheckOutController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(c => c.Quantity * c.Product.Price);
            return View();
        }
    }
}
