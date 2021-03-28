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
    [Route("product/category")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ICategory>> Get()
        {
            var items = _category.GetAllCategories();
            return Ok(items);
        }

        [HttpPost]
        public ActionResult<Category> Post(Category category)
        {
            _category.CreateCategory(category);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult <Category> GetById(int id)
        {
            var item = _category.GetCategoryById(id);
            if (item == null)
                return NotFound();
            else
                return Ok(item);
        }
    }
}
