using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public class SqlAddress : IAddress
    {
        private readonly CommerceContext _context;

        public SqlAddress(CommerceContext commerceContext)
        {
            _context = commerceContext;
        }

        public void CreateAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void DeleteAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            _context.Addresses.Remove(address);
        }

        public Address GetAddressByEmail(string email)
        {
            return _context.Addresses.FirstOrDefault(x => x.Email == email);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }
    }
}
