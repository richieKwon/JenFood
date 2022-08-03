using System.Collections.Generic;
using System.Linq;
using JenKitchen.Models;
using Microsoft.EntityFrameworkCore;

namespace JenFood.Models
{
    public class FoodRepository: IFoodRepository
    {
        private readonly AppDbContext _appDbContext;

        public FoodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Food> AllFoods
        {
            get { return _appDbContext.Foods.Include(f => f.Category); }
        }

        public IEnumerable<Food> FoodsOfTheWeek
        {
            get { return _appDbContext.Foods.Include(f=>f.Category).Where(f =>f.IsFoodOfTheWeek);}
        }
        public Food GetFoodById(int foodId)
        {
            return _appDbContext.Foods.FirstOrDefault(f => f.FoodId == foodId);
        }
    }
}