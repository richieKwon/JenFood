using System.Collections.Generic;

namespace JenKitchen.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Food> AllFoods { get; }
        IEnumerable<Food> FoodsOfTheWeek { get; }
        Food GetFoodById(int foodId);
    }
}