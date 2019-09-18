using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace ContactLab.Models
{
    public class Model
    {
        private ContactBLL contacts = new ContactBLL();

        public List<Contact> getList() {
            return contacts.getContacts();
        }

        public Contact getContactDetails(int id) {
            return contacts.getDetails(id);
        }

        public void deleteRecord(int id)
        {
            contacts.Delete(id);
        }

        public void addRecord(Contact contact)
        {
            contacts.Add(contact);
        }

        public void updateRecords(Contact contact)
        {
            contacts.Update(contact);
        }
    }
}