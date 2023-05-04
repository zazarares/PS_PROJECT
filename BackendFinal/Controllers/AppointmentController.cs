using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Post(Appointment W)
        {
            Context c = new Context();
            c.Appointments.Add(W);
            c.SaveChanges();
        }
    }
}
