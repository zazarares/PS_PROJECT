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
    public class AdminController : ControllerBase
    {
        private readonly ILogger<DonatorController> _logger;
        public AdminController(ILogger<DonatorController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(Admin W)
        {
            Context c = new Context();
            c.Admins.Add(W);
            c.SaveChanges();
        }


        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            var C = new Context();
            List<Admin> L = new List<Admin>();
            L = C.Admins.ToList();
            return L;
        }
    }
}
