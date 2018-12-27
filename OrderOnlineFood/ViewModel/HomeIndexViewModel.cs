using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderOnlineFood.Models;

namespace OrderOnlineFood.ViewModel
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
