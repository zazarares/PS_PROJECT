using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendFinal
{
    public class User_Working
    {
        [Key]
        public int id { get; set; }
        static int gid = 0;
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
        public User_Working(string username, string password, int type)
        {
            id = gid;
            gid++;
            this.username = username;
            this.password = password;
            this.userType = type;
        }
        public User_Working() { }
    }
}