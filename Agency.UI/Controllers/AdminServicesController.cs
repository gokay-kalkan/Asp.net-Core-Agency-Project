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
    [Authorize(Roles ="admin")]
    public class AdminServicesController : Controller
    {
        ServicesManager servicesmanager = new ServicesManager();
        public IActionResult Index()
        {
            var list = servicesmanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Services data)
        {
            if (ModelState.IsValid)
            {
                servicesmanager.ServicesAdd(data);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Veriler eklenirken hata oluştu");
            return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = servicesmanager.GetByServicesID(id);
            
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Services data)
        {
            servicesmanager.ServicesUpdate(data);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(Services data)
        {
            servicesmanager.ServicesDelete(data);
            return RedirectToAction("Index");
        }
    }
}
