using System.Collections.Generic;
using JenKitchen.Models;

namespace JenKitchen.ViewModels
{
    public class FoodsListViewModel
    {
        public IEnumerable<Food> Foods { get; set; }
        public string CurrentCategory { get; set; }

    }
}