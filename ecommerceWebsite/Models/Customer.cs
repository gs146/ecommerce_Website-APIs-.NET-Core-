using System;
using System.Collections.Generic;

#nullable disable

namespace ecommerceWebsite.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public int CustId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
