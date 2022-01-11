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
    public class IstatisticManager : IstatisticService
    {
        Repository<Istatistic> repoistatatistic = new Repository<Istatistic>();

        public Istatistic GetByIstatisticID(int id)
        {
            return repoistatatistic.GetByID(id);
        }

        public List<Istatistic> GetList(int id)
        {
            return repoistatatistic.GetList(x => x.Id == id);
        }

        public void IstatisticAdd(Istatistic istatistic)
        {
            repoistatatistic.Insert(istatistic);
        }

        public void IstatisticDelete(Istatistic istatistic)
        {
            var delete = repoistatatistic.GetByID(istatistic.Id);

            repoistatatistic.Delete(delete);
        }

        public void IstatisticUpdate(Istatistic istatistic)
        {
            var update = repoistatatistic.GetByID(istatistic.Id);
            update.Completed = istatistic.Completed;
            update.Customers = istatistic.Customers;
            update.Projects = istatistic.Projects;
            update.CompletedClass = istatistic.CompletedClass;
            update.ProjectClass = istatistic.ProjectClass;
            update.CustomersClass = istatistic.CustomersClass;
            repoistatatistic.Update(istatistic);
        }

        public List<Istatistic> List()
        {
            return repoistatatistic.List();
        }
    }
}
