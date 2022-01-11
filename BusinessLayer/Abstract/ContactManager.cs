using BusinessLayer.Concrete;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class ContactManager : ContactService
    {
        Repository<Contact> repocontact = new Repository<Contact>();
        DbContext db = new DbContext();
        public void ContactAdd(Contact contact)
        {
            contact.Status = false;
            repocontact.Insert(contact);
        }

        public List<Contact> ContactCount()
        {
            return db.Contacts.Where(x => x.Status == false).ToList();
        }

        public void ContactDelete(Contact contact)
        {
            repocontact.Delete(contact);
        }

        public List<Contact> ContactStatusList()
        {
            return db.Contacts.Where(x => x.Status == false).ToList();
        }

        public void ContactStatusUpdate(Contact contact)
        {
            var update = repocontact.GetByID(contact.Id);

             update.Status = true;
            repocontact.Update(update);
        }

        public void ContactUpdate(Contact contact)
        {
            repocontact.Update(contact);
        }

        public Contact GetByContactID(int id)
        {
            return repocontact.GetByID(id);
        }

        public List<Contact> GetList(int id)
        {
            return repocontact.GetList(x => x.Id == id);
        }

        public List<Contact> List()
        {
          return  repocontact.List();
        }
    }
}
