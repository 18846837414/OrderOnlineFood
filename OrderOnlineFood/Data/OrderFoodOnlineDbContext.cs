using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using OrderOnlineFood.Models;

namespace OrderOnlineFood.Data
{
    public class OrderFoodOnlineDbContext :DbContext
    {
        public OrderFoodOnlineDbContext(DbContextOptions options) :base(options)
        {
           
        }

       public DbSet<Restaurant> Restaurants { get; set; }
    }
}
