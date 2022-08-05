using System.Collections.Generic;
using JenKitchen.Models;

namespace JenKitchen.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Food> FoodsOfTheWeek { get; set; }
    }
}