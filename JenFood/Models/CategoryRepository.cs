using System.Collections.Generic;
using JenKitchen.Models;

namespace JenFood.Models
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> Allcategories => _appDbContext.Categories; 
        // {
        //     get { return _appDbContext.Categories; }
        // }
    }
}