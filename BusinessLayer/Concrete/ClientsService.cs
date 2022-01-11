using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public interface ClientsService
    {
        List<Clients> List();

        Clients GetByClientsID(int id);
        void ClientsDelete(Clients clients);
        void ClientsAdd(Clients clients);
        void ClientsUpdate(Clients clients);
        List<Clients> GetList(int id);
    }
}
