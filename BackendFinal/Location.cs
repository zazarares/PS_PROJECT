using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BackendFinal
{
    public class Location
    {
        [Key]
        public int id { get; set; }
        public int[] slots=new int[12];
        static int gid = 0;
        public string name { get; set; }
        public Location()
        {
            for (int i=0;i<12;i++)
            {
                //gid++;
                //id = gid;
                name = "";
                slots[i] = 5;
            }

        }
        public Location(string name,int[] slots)
        {
            gid++;
            id = gid;
            this.name = name;
            this.slots = slots;
        }
    }
}
