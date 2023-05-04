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
    public class DoctorController : ControllerBase
    {

        private readonly ILogger<Doctor> _logger;
        Doctor d;
        public DoctorController(ILogger<Doctor> logger)
        {
            _logger = logger;
        }
        /*
        public void setDoctor(Doctor d)
        {
            this.d = d;
        }*/
        [HttpGet]
        public List<Doctor> Get()
        {
            Doctor d = new Doctor();
            d.CNP = "56273712";
            d.FirstName = "Toma";
            d.LastName = "Caragiu";
    
            Context C=new Context();
            List<Doctor> DL = C.Doctors.ToList<Doctor>();
            return DL;
        }
    }
}
