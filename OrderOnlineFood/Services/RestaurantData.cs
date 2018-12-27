using OrderOnlineFood.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderOnlineFood.Services
{
    public class RestaurantData :IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public RestaurantData()
        {
           _restaurants =new List<Restaurant>
           {
               //new Restaurant{Id = 20,Name = "KFC"},
               //new Restaurant{Id=45,Name = "Domino's"},
               
           };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant GetRestaurant(int id)
        {
            return _restaurants.FirstOrDefault(restaurant => restaurant.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _restaurants.Add(restaurant);
            return restaurant;

        }
    }
}
