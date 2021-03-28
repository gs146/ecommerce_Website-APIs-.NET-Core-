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
    [Route("api/order")]
    public class OrderController:ControllerBase
    {
        private readonly IOrder _order;

        public OrderController(IOrder order)
        {
            _order = order;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllOrder()
        {
            var items = _order.Orders();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<Order> Post(Order order)
        {
            _order.AddOrder(order);
            return Ok();
        }

        
    }
}
