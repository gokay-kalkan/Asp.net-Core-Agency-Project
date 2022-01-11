using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Client:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ClientsManager cm = new ClientsManager();
            var list = cm.List();
            return View(list);
        }
    }
}
