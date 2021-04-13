using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAssignment_Csharp4_Dungna29.Context;
using FinalAssignment_Csharp4_Dungna29.IServices;
using FinalAssignment_Csharp4_Dungna29.Models;
using FinalAssignment_Csharp4_Dungna29.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.VisualBasic;

namespace FinalAssignment_Csharp4_Dungna29.Controllers
{
    public class ProductsController : Controller
    {
        private IProductServices _iProductServices;
        private readonly DatabaseContext _databaseContext;
        public ProductsController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _iProductServices = new ProductServices(_databaseContext);
        }
        public IActionResult Index()
        {
            try
            {
                var lstProducts = _iProductServices.GetLstProducts();
                return View(lstProducts);
            }
            catch (Exception e)
            {
                return View();
            }

        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (product.Id == 0)
                    {
                        _iProductServices.Save(product);
                    }

                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public IActionResult Delete(int idProduct)
        {
            var product = _iProductServices.getProductObj(idProduct);
            return View(product);
           

        }
        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Product product)
        {
            var temp = _iProductServices.GetLstProducts();
            try
            {
                if (ModelState.IsValid)
                {
                    if (_iProductServices.checkIdProduct(product.Id))
                    {
                        _iProductServices.Delete(product.Id);
                    }

                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index");
            }

        }
    }
}
