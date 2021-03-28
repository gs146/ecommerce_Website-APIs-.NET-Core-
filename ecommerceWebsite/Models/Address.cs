using System;
using System.Collections.Generic;

#nullable disable

namespace ecommerceWebsite.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public string AddressType { get; set; }

        public virtual Customer EmailNavigation { get; set; }
    }
}
