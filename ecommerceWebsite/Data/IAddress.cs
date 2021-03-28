using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface IAddress
    {
        bool SaveChanges();
        Address GetAddressByEmail(string email);
        void CreateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
