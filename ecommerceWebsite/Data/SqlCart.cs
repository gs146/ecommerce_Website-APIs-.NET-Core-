using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{

    public class SqlCart : ICart
    {
        private readonly CommerceContext _context;

        public SqlCart(CommerceContext context)
        {
            _context = context;
        }

        public void AddItemInCart(Cart cart)
        {
            int productId = cart.ProductId;

            var item = _context.Products.FirstOrDefault(x => x.ProductId == productId);
            cart.CostPerUnit = item.Price;

           


            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public void DeleteItemFromCart(Cart cart)
        {
            if (cart == null)
                throw new ArgumentNullException(nameof(cart));
            _context.Carts.Remove(cart);
        }

        public IEnumerable<Cart> GetAllItems()
        {
            return _context.Carts.ToList();
        }

        public Cart GetItemById(int id)
        {
            return _context.Carts.FirstOrDefault(x=>x.CartId==id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
