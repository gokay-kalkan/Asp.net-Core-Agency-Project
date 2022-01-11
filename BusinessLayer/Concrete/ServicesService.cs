using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public interface ServicesService
    {
        List<Services> List();

        Services GetByServicesID(int id);
        void ServicesDelete(Services services);
        void ServicesAdd(Services services);
        void ServicesUpdate(Services services);


        List<Services> GetList(int id);
    }
}
