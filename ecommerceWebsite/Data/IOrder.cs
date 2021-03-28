using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface IOrder
    {
        bool SaveChanges();
        IEnumerable<Order> Orders();
        void AddOrder(Order order);

        //void DeleteOrder(Order order);
    }
}
