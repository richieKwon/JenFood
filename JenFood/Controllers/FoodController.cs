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
        
        public IActionResult List()
        {
            // ViewBag.CurrentCategory = "BBQ";
            FoodsListViewModel foodsListViewModel = new FoodsListViewModel();
            foodsListViewModel.Foods = _foodRepository.AllFoods;
            foodsListViewModel.CurrentCategory = "BBQ";
            
            return View(foodsListViewModel);
        }
    }
}