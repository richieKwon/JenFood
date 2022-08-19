using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JenFood.Models;
using JenKitchen.Models;
using Microsoft.AspNetCore.Mvc;

namespace JenFood.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepository _foodRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodRepository foodRepository, ShoppingCart shoppingCart)
        {
            _foodRepository = foodRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}