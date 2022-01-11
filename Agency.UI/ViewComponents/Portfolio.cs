using BusinessLayer.Abstract;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.ViewComponents
{
    public class Portfolio:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DbContext db = new DbContext();
            PortfolioManager pm = new PortfolioManager();
            var portfolios = pm.List();
            var web = db.Portfolios.Where(x=>x.Name=="Web").Take(1).Where(x=>x.Name=="Seo").Take(1).ToList();
            ViewBag.web = web;
            

            return View(web);
        }
    }
}
