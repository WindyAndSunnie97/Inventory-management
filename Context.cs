using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKho1
{
    internal class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductsDetail { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<DcDetail> DcDetail { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, NameUser = "Nguyễn Công Giới", Email = "ahihi@gmail.com", UserName = "admin", Password="admin", RoleID = 1}      
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, NameCategory = "Soft Drink"},
                new Category { CategoryID = 2, NameCategory = "Beer" },
                new Category { CategoryID = 3, NameCategory = "Wine" },
                new Category { CategoryID = 4, NameCategory = "Mineral Water" }
                );
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryID = 1, NameInventory = "Kho 1", Address = "Cộng Hòa" }
                );
            modelBuilder.Entity<Person>().HasData(
               new Person { PersonID = 1, NamePerson = "Trần Thị Anh Thư", Phone="0945449058",Address = "103/16C Trần Qang Diệu,P14,Q3", Email = "ttathu0907@gmail.com"}
               );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, NameProduct = "Soju", Price = 60000, Origin = "Korea", CategoryID = 3 },
                 new Product { ProductID = 2, NameProduct = "Tiger", Price = 15000, Origin = "Korea", CategoryID = 2 },
                  new Product { ProductID = 3, NameProduct = "SaiGon", Price = 12000, Origin = "Korea", CategoryID = 2 }
               );
            
        }
    }
}
