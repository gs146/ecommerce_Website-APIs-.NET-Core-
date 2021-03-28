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
    [Route("api/cart")]
    public class CartController:ControllerBase
    {
        private readonly ICart _cart;
        public CartController(ICart cart)
        {
            _cart = cart;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cart>> GetAllItemsFromCart()
        {
            var items= _cart.GetAllItems();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<Cart> Post(Cart cart)
        {
            _cart.AddItemInCart(cart);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(int id)
        {
            var cartObject = _cart.GetItemById(id);
            if (cartObject == null)
                return NotFound();

            _cart.DeleteItemFromCart(cartObject);
            _cart.SaveChanges();

            return NoContent();
        }
    }
}
