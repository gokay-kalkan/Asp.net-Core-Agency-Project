using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Team:ViewComponent
    {
        TeamManager tm = new TeamManager();
       public IViewComponentResult Invoke()
        {
            var list = tm.List();
            return View(list);
        }
    }
}
