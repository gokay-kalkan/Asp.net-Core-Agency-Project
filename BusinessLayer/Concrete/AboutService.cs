using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface AboutService
    {
        List<About> List();

        About GetByAboutID(int id);
        void AboutDelete(About about);
        void AboutAdd(About about);
        void AboutUpdate(About about);
       

        List<About> GetList(int id);
    }
}
