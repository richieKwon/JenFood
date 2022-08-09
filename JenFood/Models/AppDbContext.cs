using JenKitchen.Models;
using Microsoft.EntityFrameworkCore;

namespace JenFood.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Appetizer" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Main" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Dessert" });
            
            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodId = 1,
                Name = "Fried Dumpling",
                Price = 8,
                ShortDescription = "Frid dumpling with olive oil",
                LongDescription = "Combination of pork, vegetable and noodle. Enjoy crispy dumplings with hot chili sauce",
                CategoryId = 1,
                ImageUrl = "https://postfiles.pstatic.net/MjAyMjA1MDFfMjMy/MDAxNjUxNDEyNzc3NTUx.z5IQl1RGHm4SW127kK1WU7WmZas3shGHTSQZ1xQ5s70g.-sc_rvg8TSsRFHmKizu2_I5H9qZy7CgRVI5Y1n31dysg.JPEG.purple4you/IMG_7672.jpg?type=w773",
                InStock = true,
                IsFoodOfTheWeek = true,
                ImageThumbnailUrl = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyMjA3MTdfMjk2%2FMDAxNjU4MDYzMTY3MjA0.WFM4tShXm4kKbvs52uH79oIEgGj0v9xokjEsjerZlbgg.-0SZvSJQr-BHEQcJCCjdwdLfAWb_Qh3Fj_gqMxOXbH4g.JPEG.spjms52%2F20220605_190732.jpg&type=sc960_832",
                AllergyInformation = ""
            });
            
            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodId = 2,
                Name = "Pork Bulgogi",
                Price = 16,
                ShortDescription = "Seasoned pork with hot sauce",
                LongDescription = "Pork marinated with hot sauce and charcoal-cooked. Sweet and spicy!",
                CategoryId = 2,
                ImageUrl = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyMjA0MDZfMTQg%2FMDAxNjQ5MjE1Mzk0NDQy.IoRH2PrHmCMNtgrDxJFiddTxLn0d44JuRajnpp0wSfAg.tKICY5we3ypPTfdd7uEpTT1iCP7_gWYKbsiJ3AJf-Nwg.JPEG.soulrin84%2F20220402%25A3%25DF153121.jpg&type=sc960_832",
                InStock = true,
                IsFoodOfTheWeek = true,
                ImageThumbnailUrl = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyMjA3MDJfMjEx%2FMDAxNjU2NzA2OTM4Njc0.hrFZzG7M-5_Qn865rJdd13qLvvZrtH0eDjXtK_M0bnAg.ZvbakX9wvsgoQIvU8CBt6jWHf912Y4X5PRTFN22KSpgg.JPEG.hyunyangi%2F20220701%25A3%25DF141549%25A3%25DFHDR.jpg&type=sc960_832",
                AllergyInformation = ""
            });
            
            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodId = 3,
                Name = "Rice Cakes",
                Price = 7,
                ShortDescription = "Sticky rice cake",
                LongDescription = "Sticky and sweet rice cakes. holding red beans jam",
                CategoryId = 2,
                ImageUrl = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyMjA1MjFfMTkg%2FMDAxNjUzMTQzNTU0ODIz.4lNyLq-2mfbw4zbkCf_YXaO_nCiEAZmithmBSJjNk78g.JmpCXhk_tAza-rN1dW3jNJ8_5LZZDrBMnlFouJlAilMg.JPEG.ysh0155%2F20220521_181146.jpg&type=sc960_832",
                InStock = true,
                IsFoodOfTheWeek = true,
                ImageThumbnailUrl = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyMjA2MDZfNjMg%2FMDAxNjU0NDc1ODQ3NjEy.e83XawxrdUGNFkJOdr6Ay3X6iBGCWhx5P36vhIOJfQAg.onCScbu6TUxeFziH-aXcsB8hJFeuFr2glwefag9K75Ig.JPEG.s98soon%2F20220605%25A3%25DF162000.jpg&type=sc960_832",
                AllergyInformation = ""
            });
        }
    }   
}