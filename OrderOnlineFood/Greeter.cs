using Microsoft.Extensions.Configuration;
using System;

namespace OrderOnlineFood
{
    public class Greeter :IGreeter
    {
        private readonly IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public string GetMessageToPrint()
        {
            string message = _configuration["Greeting"];
            return message;
        }
    }
}
