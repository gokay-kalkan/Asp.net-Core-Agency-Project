using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface IstatisticService
    {
        List<Istatistic> List();

        Istatistic GetByIstatisticID(int id);
        void IstatisticDelete(Istatistic istatistic);
        void IstatisticAdd(Istatistic istatistic);
        void IstatisticUpdate(Istatistic istatistic);
       

        List<Istatistic> GetList(int id);
    }
}
