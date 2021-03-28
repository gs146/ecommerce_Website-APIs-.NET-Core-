using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface IPayment
    {
        bool SaveChanges();
        Payment GetPaymentByEmail(string email);
        void CreatePayment(Payment payment);
        void DeletePayment(Payment payment);

    }
}
