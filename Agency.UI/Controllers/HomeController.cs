using Agency.UI.Models;
using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        SliderManager sm = new SliderManager();
        ContactManager cm = new ContactManager();
       
        public IActionResult Index()
        {
            var sliderlist = sm.List();
            ViewBag.sliderlist = sliderlist;
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact data)
        {
            cm.ContactAdd(data);
            TempData["Message"] = "Mesajınız Başarıyla Gönderildi";
            return RedirectToAction("Index");
        }

        
    }
}
