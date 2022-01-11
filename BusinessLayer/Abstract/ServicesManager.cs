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
    public class ServicesManager : ServicesService
    {
        Repository<Services> reposervices = new Repository<Services>();
        DbContext db = new DbContext();
        public Services GetByServicesID(int id)
        {
            return reposervices.GetByID(id);
        }

        public List<Services> GetList(int id)
        {
            return reposervices.GetList(x => x.Id == id);
        }

        public List<Services> List()
        {
            return reposervices.List();
        }

        public void ServicesAdd(Services services)
        {
            reposervices.Insert(services);
        }

        public void ServicesDelete(Services services)
        {
            var delete = reposervices.GetByID(services.Id);

            reposervices.Delete(delete);
        }

        public void ServicesUpdate(Services services)
        {
            var update=reposervices.GetByID(services.Id);
            update.Description = services.Description;
            update.Name = services.Name;
            reposervices.Update(services);
        }
    }
}
