using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiStore.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("WebApiStoreDb")
        {
            Database.SetInitializer<ProductDbContext>(new ProductDbInitializer());
        } 

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }
}