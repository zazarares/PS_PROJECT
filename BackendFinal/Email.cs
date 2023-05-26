using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendFinal
{
    public class Email
    {
        public string From { get; set; }
        public string To { get; set; }
        public string subject
        {
            get; set;
        }
        public string Content
        {
            get; set;
        }
        public string PatientName
        {
            get; set;
        }
    }
}
