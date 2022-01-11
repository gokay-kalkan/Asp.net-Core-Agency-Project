using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Istatistic:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IstatisticManager im = new IstatisticManager();
            var list = im.List();
            return View(list);
        }
    }
}
