using ecommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceWebsite.Data
{
    public interface ICategory
    {
        bool SaveChanges();
         
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
    }
}
