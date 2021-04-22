using LoyaltyCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyaltyCore.Persistence
{
    public class LoyaltyDb:DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=LoyaltyDb;User ID=sa;Password=passw0rd");
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=LoyaltyDb;Integrated Security=True");
        }

    }
}
