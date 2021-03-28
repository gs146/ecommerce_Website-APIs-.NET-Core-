using System;
using System.Collections.Generic;

#nullable disable

namespace ecommerceWebsite.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public string Email { get; set; }
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardHolderName { get; set; }
        public int CardExpiryMonth { get; set; }
        public int CardExpiryYear { get; set; }
        public bool PrimaryPayment { get; set; }
        public int CardCvv { get; set; }

        public virtual Customer EmailNavigation { get; set; }
    }
}
