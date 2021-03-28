using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface ICustomer
    {
        bool SaveChanges();
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerByEmail(string email);
        void CreateCustomer(Customer cust);
        void DeleteCustomer(Customer cust);

    }
}
