using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using JenFood.Models;
using JenKitchen.Models;
using JenKitchen.ViewModels;
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

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int foodId)
        {
            var selectedFood = _foodRepository.AllFoods.FirstOrDefault(p => p.FoodId == foodId);

            if (selectedFood != null)
            {
                _shoppingCart.AddToCart(selectedFood, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int foodId)
        {
            var selectedFood = _foodRepository.AllFoods.FirstOrDefault(food => food.FoodId == foodId);

            if (selectedFood != null)
            {
                _shoppingCart.RemoveFromCart(selectedFood);
            }

            return RedirectToAction("Index");

        }


    }
}