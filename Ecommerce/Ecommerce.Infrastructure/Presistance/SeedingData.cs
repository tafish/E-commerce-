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


    }
}
