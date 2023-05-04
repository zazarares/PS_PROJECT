using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendFinal;
namespace BackendFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {

        private readonly ILogger<Location> _logger;
        Doctor d;
        public LocationController(ILogger<Location> logger)
        {
            _logger = logger;
        }
        /*
        public void setDoctor(Doctor d)
        {
            this.d = d;
        }*/
        [HttpGet]
        public List<Location> Get()
        {
            Location d = new Location();
            d.name = "CLUJ";
            
            Context C = new Context();
           // C.Locations.Add(d);
           // C.SaveChanges();
            List<Location> DL = C.Locations.ToList<Location>();
            return DL;
        }
    }
}
