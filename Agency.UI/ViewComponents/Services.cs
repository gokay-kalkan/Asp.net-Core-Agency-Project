using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Services:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ServicesManager sm = new ServicesManager();
            var servicelist = sm.List();
            ViewBag.servicelist = servicelist;
            return View(servicelist);
        }
    }
}
