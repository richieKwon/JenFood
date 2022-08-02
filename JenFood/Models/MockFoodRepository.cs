using System.Collections.Generic;
using System.Linq;

namespace JenKitchen.Models
{
    public class MockFoodRepository : IFoodRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        // public MockFoodRepository(ICategoryRepository categoryRepository)
        // {
        //     _categoryRepository = categoryRepository;  
        // }

        public IEnumerable<Food> AllFoods => new List<Food>
        {
            // new Food{FoodId = 1, Name = "Kimbob", Price = 12, ShortDescription = "RollWithRiceAndVegetables"}
            new Food {FoodId = 1, Name="Kimbob", Price=15, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot", Category = _categoryRepository.Allcategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsFoodOfTheWeek= false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
            new Food {FoodId = 2, Name="Bulgogi", Price=20, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot", Category = _categoryRepository.Allcategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsFoodOfTheWeek= false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
            new Food {FoodId = 3, Name="Hwachae", Price=8, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake", Category = _categoryRepository.Allcategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsFoodOfTheWeek= false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"}
        };
        
        
        public IEnumerable<Food> FoodsOfTheWeek { get; }
        
        
        public Food GetFoodById(int foodId)
        {
            return AllFoods.FirstOrDefault(food => food.FoodId == foodId);
        }
    }
}

// new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
