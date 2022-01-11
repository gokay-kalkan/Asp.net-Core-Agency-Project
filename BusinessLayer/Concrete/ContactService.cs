using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface ContactService
    {
        List<Contact> List();

        Contact GetByContactID(int id);
        void ContactDelete(Contact contact);
        void ContactAdd(Contact contact);
        List<Contact> ContactCount();
        void ContactUpdate(Contact contact);
        void ContactStatusUpdate(Contact contact);
        List<Contact> ContactStatusList();

        List<Contact> GetList(int id);
    }
}
