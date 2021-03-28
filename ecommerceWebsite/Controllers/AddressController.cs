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
    [Route("api/address")]
    public class AddressController:ControllerBase
    {
        private readonly IAddress _address;
        public AddressController(IAddress address)
        {
            _address = address;
        }

        [HttpGet("{email}")]
        public ActionResult <Address> GetAddressByEmail(string email)
        {
            var addressFromEmail = _address.GetAddressByEmail(email);
            if (addressFromEmail == null)
                return NotFound();

            return Ok(addressFromEmail);
        }

        [HttpPost]
        public ActionResult <Address> Post(Address address)
        {
            _address.CreateAddress(address);
            return Ok();
        }

        [HttpDelete("{email}")]
        public ActionResult Delete(string email)
        {
            var item = _address.GetAddressByEmail(email);
            if (item == null)
                return NotFound();

            _address.DeleteAddress(item);
            _address.SaveChanges();
            return Ok();
        }
    }
}
