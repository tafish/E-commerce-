using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Infrastructure.Presistance
{
    public static class SeedingData
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Tsundere"},
                new Category() { Id = 2, Name = "Tsundere" },
                new Category() { Id = 3, Name = "Yandere" },
                new Category() { Id = 4, Name = "Kuudere" },
                new Category() { Id = 5, Name = "Dandere" }

                );


        }

        public static void UserSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User() { Id = 1, FirstName = "Ahmed", LastName = "Mohamed", Email = "a@gmail.com", Password = "123456" },
               new User() { Id = 2, FirstName = "Ibrahim", LastName = "Mohamed", Email = "ah@gmail.com", Password = "123456" },
               new User() { Id = 3, FirstName = "Fath", LastName = "Mohamed", Email = "f@gmail.com", Password = "123456" }
               );
        }

        public static void ProductSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product() { Id = 1,Name = "Prodact1", Description = "tv", Price = 100, Stock = 50 },
               new Product() { Id = 2, Name = "Prodact2", Description = "lab", Price = 50, Stock = 30 },
               new Product() { Id = 3, Name = "Prodact3", Description = "pc", Price = 200, Stock = 30 }
               );
        }

        public static void visaSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<visa>().HasData(
               new visa() { id = 1, number =123456 , Evpiry_date = "10-26", type = "ahgfhjyf", UserId = 1},
               new visa() { id = 2, number =125484 , Evpiry_date = "10-28", type = "veghfsee",UserId = 1},
               new visa() { id = 3, number =178521 , Evpiry_date = "9-27", type = "fderjhfeee",UserId =1 }
               );
        }

        public static void OrderSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
               new Order() { Id = 1, OrderDate = DateTime.Now, TotalAmount = 200, UserId = 1 },
               new Order() { Id = 2, OrderDate = DateTime.Now, TotalAmount = 5000, UserId = 2 },
               new Order() { Id = 3, OrderDate = DateTime.Now, TotalAmount = 1750, UserId = 3 }
               );
        }
        public static void phoneSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<phone>().HasData(
               new phone() { id = 1, no = "no", UserId = 1 },
               new phone() { id = 2, no = "yes", UserId = 2 },
               new phone() { id = 3, no = "no" , UserId = 3 }
               );
        }

        public static void AddressSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                new Address() { id = 1, content = "Tsundere", city = "Cairo", type ="test1", UserId =1},
                new Address() { id = 2, content = "Tsundere", city = "Alexandria", type = "test2", UserId = 1 },
                new Address() { id = 3, content = "Yandere", city = "Giza", type = "test3", UserId = 1 },
                new Address() { id = 4, content = "Kuudere", city = "Luxor", type = "test4", UserId = 1 },
                new Address() { id = 5, content = "Dandere", city = "Aswan", type = "test5" , UserId = 1 }

                );
        }

        public static void BrandSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
               new Brand() { Id = 1, Name = "pc", logo = "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic" },
               new Brand() { Id = 2, Name = "micro", logo = "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic " },
               new Brand() { Id = 3, Name = "grel", logo = "https://www.google.com/search?sca_esv=6449538529ffda2f&sxsrf=ADLYWIJLPNJcSg8eNexK0snUEW47SvzYNw:1728138541243&q=%D8%B5%D9%88%D8%B1&udm=2&fbs=AEQNm0BIRlNMsRe0SeE1EXtrwm1mjePOoxRIMPk2gPjqOozch23yls1763fqJ-YUzYzv81ep_VHpm7VSSZUvFi5aYRaMWgwTx1IvZn0TMjsKHvXSPj3Lq20Qs0HT-lFx8kMr7C-Xdnb_ZD9v0QliLURUjeuihX9OBcx5nIno_GQ80GQdoSkkYGQrwdyHaxjsiIKHT5dUco2g_gnjtmLEyID0gBja_7LIL3wcI92GyMmCXvnVrVcDCA0&sa=X&ved=2ahUKEwig-_3eufeIAxVoVqQEHdeiB_MQtKgLegQIDhAB&biw=1707&bih=820&dpr=1.13#vhid=Zpu9rWGEwuB5UM&vssid=mosaic" }
               );
        }

        public static void ReviewSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review() { Id = 1, Rating = 1, Comment = "aaaaaaaa", Date = DateTime.Now, ProductId = 1, UserId=1 },
                new Review() { Id = 2, Rating = 1, Comment = "ssssssss", Date = DateTime.Now, ProductId = 1, UserId = 1 },
                new Review() { Id = 3, Rating = 2, Comment = "dddddddd", Date = DateTime.Now, ProductId = 2 , UserId = 2 },
                new Review() { Id = 4, Rating = 3, Comment = "ffffffff", Date = DateTime.Now, ProductId = 2, UserId = 2 },
                new Review() { Id = 5, Rating = 4, Comment = "gggggggg", Date = DateTime.Now, ProductId = 2, UserId = 1 }

                );
        }
    }
}
