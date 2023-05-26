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
        [HttpPost]
        public void Post(Doctor W)
        {
            Context c = new Context();
            List<User_Working> LU = c.Users.ToList();
            User_Working U=new User_Working();
            U.password = "root";
            U.username = W.FirstName + W.LastName;
            U.userType = 1;
            W.id = LU.Count + 1;
            c.Users.Add(U);
            c.SaveChanges();
            c.Doctors.Add(W);
            c.SaveChanges();
        }
        [HttpGet]
        public List<Doctor> Get()
        {
           
            /*
            Doctor d = new Doctor();
            d.CNP = "56273712";
            d.FirstName = "Toma";
            d.LastName = "Caragiu";
            User_Working u = new User_Working();
            u.username = "mihai";
            u.password = "123";
            u.userType = 1;*/
            Context C=new Context();
            /*
            C.Doctors.Add(d);
            C.SaveChanges();*/
            List<Doctor> DL = C.Doctors.ToList<Doctor>();
            return DL;
        }
    }
}
