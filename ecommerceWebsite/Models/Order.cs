using System;
using System.Collections.Generic;

#nullable disable

namespace ecommerceWebsite.Models
{
    public partial class Order
    {
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Email { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public int CartId { get; set; }
        public int OrderId { get; set; }
        public int Id { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Customer EmailNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
