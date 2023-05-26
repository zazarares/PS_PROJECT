using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendFinal
{
    public class Appointment
    {
        static int gid = 0;
        [Key]
        public int id { get; set; }
        public int timeslot { get; set; }
        public DateTime Date { get; set; }
        public int DoctorID { get; set; }
        public int DonatorID { get; set; }
        public Appointment()
        {
           // gid++;
            //id = gid;
            timeslot = 0;
        }
        public Appointment(int timeslot, DateTime Date)
        {
         //   gid++;
           // id = gid;
            this.timeslot = timeslot;
            this.Date = Date;
        }
    }
}
