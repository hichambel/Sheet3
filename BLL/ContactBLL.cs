using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ContactBLL
    {

        public List<Contact> getContacts()
        {
            return ContactDAL.contacts;
        }

        public Contact getDetails(int id)
        {
            return ContactDAL.contacts.Where(m => m.id == id).Single();  
        }
        public void Delete(int id)
        {

            ContactDAL.contacts.Where(x => x.id == id).Single().active = false;

        }
        public void Add(Contact contact)
        {
            contact.id = ContactDAL.LastId++;
            ContactDAL.contacts.Add(contact);
        }

        public void Update(Contact contact)
        {
            ContactDAL.contacts[ContactDAL.contacts.FindIndex(x => x.id == contact.id)] = contact;
        }
    }
}
