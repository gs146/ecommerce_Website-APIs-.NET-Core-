using System;
using System.Collections.Generic;

#nullable disable

namespace ecommerceWebsite.Models
{
    public partial class Cart
    {
        public Cart()
        {
            Orders = new HashSet<Order>();
        }

        public int CartId { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int CostPerUnit { get; set; }
        public string Status { get; set; }

        public virtual Customer EmailNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
