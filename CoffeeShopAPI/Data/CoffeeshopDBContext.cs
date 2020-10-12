using System;
using CoffeeShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopAPI.Data
{
    public class CoffeeshopDBContext : DbContext
    {
        public CoffeeshopDBContext(DbContextOptions<CoffeeshopDBContext> options) : base(options)
        {
        }
        public DbSet<Menu> Menu { get; set;}
        public DbSet<Order> Order { get; set; }
    }
}
