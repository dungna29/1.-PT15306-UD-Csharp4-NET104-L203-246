using FinalAssignment_Csharp4_Dungna29.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment_Csharp4_Dungna29.IServices
{
    public interface IProductServices
    {
        List<Product> GetLstProducts();
        Product GetById(int productId);

        void Save(Product product);
        void Update(Product product);
        string Delete(int productId);

        bool checkIdProduct(int idProduct);
        public Product getProductObj(int idProduct);
    }
}
