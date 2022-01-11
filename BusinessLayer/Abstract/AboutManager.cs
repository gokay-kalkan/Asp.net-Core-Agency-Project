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
    public class AboutManager : AboutService
    {
        Repository<About> repoabout = new Repository<About>();

        public void AboutAdd(About about)
        {
            repoabout.Insert(about);
        }

        public void AboutDelete(About about)
        {
            repoabout.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            repoabout.Update(about);
        }

        public About GetByAboutID(int id)
        {
            return repoabout.GetByID(id);
        }

        public List<About> GetList(int id)
        {
            return repoabout.GetList(x=>x.Id==id);
        }

        public List<About> List()
        {
            return repoabout.List();
        }
    }
}
