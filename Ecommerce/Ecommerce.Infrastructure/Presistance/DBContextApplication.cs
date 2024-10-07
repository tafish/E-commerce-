using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Presistance
{
    public class DBContextApplication : DbContext
    {
        public DBContextApplication(DbContextOptions<DBContextApplication> options)
           : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<phone> phones { get; set; }
        public DbSet<visa> visa { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<ReplyReview> ReplyReviews { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.CategorySeed();
            modelBuilder.UserSeed();
            modelBuilder.ProductSeed();
            modelBuilder.OrderSeed();
            modelBuilder.visaSeed();
            modelBuilder.phoneSeed();
            modelBuilder.AddressSeed();
            modelBuilder.ReviewSeed();
            modelBuilder.BrandSeed();
        }   










    }
}
