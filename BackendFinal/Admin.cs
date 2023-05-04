using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BackendFinal
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public Admin() {; }
        public User_Working U = new User_Working();

    }
}