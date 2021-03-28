using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface IProduct
    {
        bool SaveChanges();
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        IEnumerable<Product> GetProductByCategory(int category_id);
        void CreateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
