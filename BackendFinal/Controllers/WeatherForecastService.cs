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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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
            User_Working u = new User_Working();
            u.id = 0;
            u.password = "Marin";
            u.username = "Medicu";
            u.userType = 1;
            //C.Users.Add(u);
            //C.SaveChanges();
            u=C.Users.Find(1);
            List<User_Working> L = new List<User_Working>();
            L = C.Users.ToList();
            return L;
        }
    }
}
