using System.Linq;
using JenKitchen.Models;
using Microsoft.AspNetCore.Mvc;

namespace JenFood.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Allcategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}