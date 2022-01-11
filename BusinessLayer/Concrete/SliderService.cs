using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public interface SliderService
    {
        List<Slider> List();

        Slider GetBySliderID(int id);
        void SliderDelete(Slider slider);
        void SliderAdd(Slider slider);
        void SliderUpdate(Slider slider);


        List<Slider> GetList(int id);
    }
}
