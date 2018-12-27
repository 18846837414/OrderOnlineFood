using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderOnlineFood.Models;

namespace OrderOnlineFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetRestaurant(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
