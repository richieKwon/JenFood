using System.Collections.Generic;

namespace JenKitchen.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Allcategories => new List<Category>
        {
            new Category{CategoryId = 1, CategoryName = "Dessert", Description = "TraditionalDessert"},
            new Category{CategoryId = 2, CategoryName = "BBQ", Description = "KoreanStyleBBQ"},
            new Category{CategoryId = 3, CategoryName = "Roll", Description = "RollWithRice"}
        };
    }
}
