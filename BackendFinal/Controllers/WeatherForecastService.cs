using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastService : ControllerBase
    {

        private readonly ILogger<WeatherForecastService> _logger;
        public WeatherForecastService(ILogger<WeatherForecastService> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(User_Working W)
        {
            Context c = new Context();
            c.Users.Add(W);
            c.SaveChanges();
        }


        [HttpGet]
        public IEnumerable<User_Working> Get()
        {
            var C = new Context();
            List<User_Working> L = new List<User_Working>();
            L = C.Users.ToList();
            return L;
        }
    }
}
