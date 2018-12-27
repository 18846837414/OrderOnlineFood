using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderOnlineFood.Data;
using OrderOnlineFood.Models;

namespace OrderOnlineFood.Services
{
   
    public class SqlServerRestaurantData :IRestaurantData
    {
        private OrderFoodOnlineDbContext _context;

        public SqlServerRestaurantData(OrderFoodOnlineDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Restaurant> GetAll()
        {
          return _context.Restaurants.OrderBy(restaurant => restaurant.Id);
           

        }

        public Restaurant GetRestaurant(int id)
        {
            var newRestaurant = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
            return newRestaurant;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }
    }
}
