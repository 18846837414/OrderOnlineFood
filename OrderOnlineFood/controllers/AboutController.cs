using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderOnlineFood.controllers
{
    //[Route("about")]
    //Token controller routing
    //[Route("[controller]")]
    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
      // [Route("")]
        //[Route("[action]")]
        public string Address()
        {
            return "Rjy";
        }
        [Route("[action]")]
        public double PhoneNumber()
        {
            return 456;
        }
    }
}
