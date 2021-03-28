using ecommerceWebsite.Data;
using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController:ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        //get all product
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var items = _product.GetAllProduct();
            return Ok(items);
        }

        //create product
        [HttpPost]
        public ActionResult<Customer> Post(Product product)
        {
            _product.CreateProduct(product);
            return Ok();
        }

        //get product by id
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var item = _product.GetProductById(id);

            if (item != null)
                return Ok(item);

            return NotFound();
        }

        //delete product
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var productObject = _product.GetProductById(id);

            if (productObject== null)
                return NotFound();

            _product.DeleteProduct(productObject);
            _product.SaveChanges();

            return NoContent();
        }

        //get products by category
        [HttpGet("find/{id}")]
        public ActionResult<IEnumerable<Product>> GetByCategory(int id)
        {
            var items =  _product.GetProductByCategory(id);
            return Ok(items);
        }

    }
}
