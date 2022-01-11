using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class About: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutManager  abm = new AboutManager();
            var aboutlist = abm.List();
           ViewBag.aboutlist = aboutlist;
            return View(aboutlist);
        }
    }
}
