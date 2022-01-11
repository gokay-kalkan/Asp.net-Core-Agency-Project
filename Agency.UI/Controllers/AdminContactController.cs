using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminContactController : Controller
    {
        ContactManager cm = new ContactManager();
        public IActionResult Index()
        {
            var list = cm.List();

            return View(list);
        }
        public IActionResult Update(int id)
        {
            var update = cm.GetByContactID(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Update(Contact data)
        {
             cm.ContactStatusUpdate(data);
            return RedirectToAction("Index");
        }
        public PartialViewResult ContactCount()
        {
            var list = cm.ContactCount().Count();
            ViewBag.count = list;
            return PartialView();
        }
    }
}
