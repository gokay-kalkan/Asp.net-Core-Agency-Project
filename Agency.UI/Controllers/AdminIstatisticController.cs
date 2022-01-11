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
    public class AdminIstatisticController : Controller
    {
        IstatisticManager istatisticmanager = new IstatisticManager();
        public IActionResult Index()
        {
            var list = istatisticmanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Istatistic data)
        {
            istatisticmanager.IstatisticAdd(data);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var update = istatisticmanager.GetByIstatisticID(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Istatistic data)
        {
            istatisticmanager.IstatisticUpdate(data);
            return RedirectToAction("Index");
            
        }
        public IActionResult Delete(Istatistic data)
        {
            istatisticmanager.IstatisticDelete(data);
            return RedirectToAction("Index");
        }
    }
}
