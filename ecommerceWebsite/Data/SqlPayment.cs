using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public class SqlPayment:IPayment
    {
        private readonly CommerceContext _context;

        public SqlPayment(CommerceContext context)
        {
            _context = context;
        }

        public void CreatePayment(Payment payment)
        {
            if (payment == null)
                throw new ArgumentNullException(nameof(payment));

            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public void DeletePayment(Payment payment)
        {
            if (payment == null)
                throw new ArgumentNullException(nameof(payment));

            _context.Payments.Remove(payment);
        }

        public Payment GetPaymentByEmail(string email)
        {
            return _context.Payments.FirstOrDefault(x => x.Email == email);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
