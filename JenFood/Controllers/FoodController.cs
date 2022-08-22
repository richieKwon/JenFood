using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JenKitchen.Models;
using JenKitchen.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JenKitchen.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ICategoryRepository _categoryRepository;

        public FoodController(IFoodRepository foodRepository, ICategoryRepository categoryRepository)
        {
            _foodRepository = foodRepository;
            _categoryRepository = categoryRepository;
        }
        
        // public IActionResult List()
        // {
        //     // ViewBag.CurrentCategory = "BBQ";
        //     FoodsListViewModel foodsListViewModel = new FoodsListViewModel();
        //     foodsListViewModel.Foods = _foodRepository.AllFoods;
        //     foodsListViewModel.CurrentCategory = "BBQ";
        //     
        //     return View(foodsListViewModel);
        // }
        
        public IActionResult Details(int id)
        {
            var food = _foodRepository.GetFoodById(id);
            if (food==null)
            {
                return NotFound();
            }
            else
            {
                return View(food);
            }
            
        }

        public ViewResult List(string category)
        {
            IEnumerable<Food> foods;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                foods = _foodRepository.AllFoods.OrderBy(f => f.FoodId);
                currentCategory = "All foods";
            }
            else
            {
                foods = _foodRepository.AllFoods.Where(f => f.Category.CategoryName == category).OrderBy(f => f.FoodId);
                currentCategory = _categoryRepository.Allcategories.FirstOrDefault(c => c.CategoryName == category)
                    .CategoryName;
            }

            return View(new FoodsListViewModel { Foods = foods, CurrentCategory = currentCategory});
        }
    }
}