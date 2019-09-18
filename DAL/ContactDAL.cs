using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContactDAL
    {
        public static int LastId = 0;

        public static List<Contact> contacts = new List<Contact>() {
            new Contact(){ id=1,firstName="Hicham",lastName="Belkaid",mobileNum="438-994-5488",homeNum="450-413-4679",businessNum="450-567-5674",address="245 rue Lafayette",notes="Best student",active=true},
            new Contact(){ id=2,firstName="Amin",lastName="Mesloui",mobileNum="438-464-7456",homeNum="450-354-8675",businessNum="450-987-6587",address="453 rue Opera",notes="",active=true},
            new Contact(){ id=3,firstName="Karim",lastName="Ibrahim",homeNum="450-885-4633",businessNum="450-345-0987",address="267 rue Champlain",notes="Worst student",active=true}
        };
    }
}
