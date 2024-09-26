using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
    public static class SeedingData
    {
        public static void CategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Tsundere" },
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
               new Product() { Id = 1, Description = "tv", Price = 100, Stock = 50},
               new Product() { Id = 2, Description = "lab", Price = 50, Stock =30 },
               new Product() { Id = 3, Description = "pc", Price = 200, Stock =30}
               );
        }
    }
}
