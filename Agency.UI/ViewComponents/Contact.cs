using BusinessLayer.Abstract;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Contact:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager cm = new ContactManager();

            var list = cm.ContactCount().Count();
            ViewBag.count = list;
            return View();
        }
    }
}
