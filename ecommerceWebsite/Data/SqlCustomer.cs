using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    
    public class SqlCustomer: ICustomer
    {
        private readonly CommerceContext _context;

        public SqlCustomer(CommerceContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer cust)
        {
            if (cust == null)
            {
                throw new ArgumentNullException(nameof(cust));
            }
            
            _context.Customers.Add(cust);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer cust)
        {
            if (cust == null)
            {
                throw new ArgumentNullException(nameof(cust));
            }

            _context.Customers.Remove(cust);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(x => x.Email == email);
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
