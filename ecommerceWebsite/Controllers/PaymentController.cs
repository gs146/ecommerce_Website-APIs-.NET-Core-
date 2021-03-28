using ecommerceWebsite.Data;
using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController:ControllerBase
    {
        private readonly IPayment _payment;
        
        public PaymentController(IPayment payment)
        {
            _payment = payment;
        }


        [HttpGet("{email}")]
        public ActionResult<Payment> GetPaymentByEmail(string email)
        {
            var item = _payment.GetPaymentByEmail(email);

            if (item != null)
                return Ok(item);

            return NotFound();
        }

        [HttpPost]
        public ActionResult<Payment> Post(Payment payment)
        {
            _payment.CreatePayment(payment);
            return Ok();
        }

        [HttpDelete("{email}")]
        public ActionResult<Payment> Delete(string email)
        {
            var paymentObject = _payment.GetPaymentByEmail(email);
            if (paymentObject == null)
                return NotFound();

            _payment.DeletePayment(paymentObject);
            _payment.SaveChanges();

            return NoContent();
        }
    }
}
