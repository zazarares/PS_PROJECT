using Microsoft.AspNetCore.Mvc;
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
    public class AppointmentController : Controller
    {
        private readonly ILogger<AppointmentController> _logger;
        Doctor d;
        public AppointmentController(ILogger<AppointmentController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public void Post(Appointment W)
        {
            Context c = new Context();
            c.Appointments.Add(W);
            c.SaveChanges();
        }
        [HttpGet]
        public List<Appointment> Get()
        {
            Context C = new Context();
            List<Appointment> DL = C.Appointments.ToList<Appointment>();
            return DL;
        }
    }
}
