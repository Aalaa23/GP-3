using Gp_3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gp_3.Data
{
    public class ShoppingDbContext : IdentityDbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
            : base(options)
        {
            
        }
        //Users Tables: 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }

        //Product Related
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //Cart Related : 

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProducts> CartProducts { get; set; }

        //Order Related : 
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        //WishList Related : 

        public DbSet<WishList> WishLists { get; set; }
        public DbSet<WishListProducts> WishListProducts { get; set; }

        //Addresses Related : 
        public DbSet<CustomerAddress> Addresses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
    }
}
