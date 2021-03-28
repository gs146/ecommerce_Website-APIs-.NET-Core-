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
    [Route("api/customer")]
    public class CustomerController:ControllerBase
    {
        private readonly ICustomer _customer;

        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomer()
        {
            var items = _customer.GetAllCustomer();
            return Ok(items);
        }

        [HttpGet("{email}", Name ="getByEmail")]
        public ActionResult<Customer> GetCustomerByEmail(string email)
        {
            var item = _customer.GetCustomerByEmail(email);

            if (item != null)
                return Ok(item);

            return NotFound();
        }

        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            _customer.CreateCustomer(customer);
            return Ok();
        }

        [HttpDelete("{email}")]
        public ActionResult<Customer> Delete(string email)
        {
            var customerObject = _customer.GetCustomerByEmail(email);
            if (customerObject == null)
                return NotFound();

            _customer.DeleteCustomer(customerObject);
            _customer.SaveChanges();

            return NoContent();
           
            
        }

    }
}
