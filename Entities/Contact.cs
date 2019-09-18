using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contact
    {
        public int id { get; set; }
        public string firstName {get; set;}
        public string lastName { get; set; }
        public string mobileNum { get; set;  }
        public string homeNum { get; set; }
        public string businessNum { get; set; }
        public string address { get; set; }
        public string notes { get; set; }
        public bool active { get; set; }
    }
}
