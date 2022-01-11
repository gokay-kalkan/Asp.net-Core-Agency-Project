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
    public class SliderManager : SliderService
    {
        Repository<Slider> reposlider = new Repository<Slider>();

        public Slider GetBySliderID(int id)
        {
            return reposlider.GetByID(id);
        }

        public List<Slider> GetList(int id)
        {
            return reposlider.GetList(x => x.Id == id);
        }

        public List<Slider> List()
        {
            return reposlider.List();
        }

        public void SliderAdd(Slider slider)
        {
             reposlider.Insert(slider);
        }

        public void SliderDelete(Slider slider)
        {
            var delete = reposlider.GetByID(slider.Id);
            reposlider.Delete(delete);
        }

        public void SliderUpdate(Slider slider)
        {
          
           
            reposlider.Update(slider);
        }
    }
}
