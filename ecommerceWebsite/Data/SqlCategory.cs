using ecommerceWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public class SqlCategory : ICategory
    {
        private readonly CommerceContext _context;

        public SqlCategory(CommerceContext context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
