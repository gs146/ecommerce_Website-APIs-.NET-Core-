using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface ICart
    {
        bool SaveChanges();
        IEnumerable<Cart> GetAllItems();

        Cart GetItemById(int id);
        void AddItemInCart(Cart cart);
        void DeleteItemFromCart(Cart cart);
    }
}
