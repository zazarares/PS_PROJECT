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
    public class DonatorController : ControllerBase
    { 
        private readonly ILogger<DonatorController> _logger;
        public DonatorController(ILogger<DonatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(Donator W)
        {
            Context c = new Context();
            c.Donators.Add(W);
            c.SaveChanges();
        }


        [HttpGet]
        public IEnumerable<Donator> Get()
        {
            var C = new Context();
            List<Donator> L = new List<Donator>();
            L = C.Donators.ToList();
            return L;
        }
    }
}
