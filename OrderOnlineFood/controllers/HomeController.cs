using Microsoft.AspNetCore.Mvc;
using OrderOnlineFood.Models;
using OrderOnlineFood.Services;
using OrderOnlineFood.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderOnlineFood.controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantInMemoryData;
        private IGreeter _greeter;
        public HomeController(IRestaurantData restaurantInMemoryData, IGreeter greeter)
        {
            _restaurantInMemoryData = restaurantInMemoryData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            //Restaurant restaurant = new Restaurant {Id = 10, Name = "Domino's"};
            //return  new ObjectResult(res);
            //return View(restaurant);
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantInMemoryData.GetAll();
            model.CurrentMessage = _greeter.GetMessageToPrint();
            //var model=_restaurantInMemoryData.GetAll();
            return View(model);

        }

        public IActionResult Details(int id)
        {
            var detailsToShow = _restaurantInMemoryData.GetRestaurant(id);
            if (detailsToShow == null)
            {
                return NotFound("No restaurant Found");
            }

            return View(detailsToShow);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
               // var newRestaurant = new Restaurant {Id = 12, Name = restaurant.Name};
                //newRestaurant = _restaurantInMemoryData.Add(newRestaurant);
                return RedirectToAction(nameof(Details), new {});
            }
            else
            {
                return View();
            }


        }
    }
}
