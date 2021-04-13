using FinalAssignment_Csharp4_Dungna29.Context;
using FinalAssignment_Csharp4_Dungna29.IServices;
using FinalAssignment_Csharp4_Dungna29.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_Csharp4_Dungna29.Services
{
    public class ProductServices : IProductServices
    {
        private readonly DatabaseContext _context;
        private List<Product> lstProducts;
        public ProductServices(DatabaseContext context)
        {
           
            lstProducts = new List<Product>();
            _context = context;
            GetLstProducts();
        }

        public string Delete(int productId)
        {
            var product = _context.Products.FirstOrDefault(c => c.Id == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return "Xóa thành công";
        }

        public Product GetById(int productId)
        {
            return _context.Products.SingleOrDefault(c => c.Id == productId);
        }

        public List<Product> GetLstProducts()
        {
            lstProducts = _context.Products.ToList();
            return lstProducts;
        }

        public void Save(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChangesAsync();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public bool checkIdProduct(int idProduct)
        {
            return lstProducts.Any(c => c.Id == idProduct);
        }

        public Product getProductObj(int idProduct)
        {
            return lstProducts.Where(c => c.Id == idProduct).FirstOrDefault();
        }
    }
}
