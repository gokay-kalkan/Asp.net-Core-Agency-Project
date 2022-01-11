using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class ClientsManager : ClientsService
    {
        Repository<Clients> repoclients = new Repository<Clients>();
        public void ClientsAdd(Clients clients)
        {
            repoclients.Insert(clients);
        }

        public void ClientsDelete(Clients clients)
        {
            var delete = repoclients.GetByID(clients.Id);
            repoclients.Delete(delete);
        }

        public void ClientsUpdate(Clients clients)
        {
            repoclients.Update(clients);
        }

        public Clients GetByClientsID(int id)
        {
            return repoclients.GetByID(id);
        }

        public List<Clients> GetList(int id)
        {
            return repoclients.GetList(x => x.Id == id);
        }

        public List<Clients> List()
        {
            return repoclients.List();
        }
    }
}
