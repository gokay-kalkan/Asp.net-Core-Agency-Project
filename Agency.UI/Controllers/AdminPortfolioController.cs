using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Agency.UI.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminPortfolioController : Controller
    {
        PortfolioManager portfoliomanager = new PortfolioManager();
        public IActionResult Index()
        {
            var list = portfoliomanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Portfolio data)
        {

            if (ModelState.IsValid)
            {
                if (data.UploadImage != null)
                {
                    var uzanti = Path.GetExtension(data.UploadImage.FileName);
                    var newname = Guid.NewGuid() + uzanti;
                    var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                    var stream = new FileStream(uploadstream, FileMode.Create);
                    data.UploadImage.CopyTo(stream);
                    data.Image = newname;

                    portfoliomanager.PortfolioAdd(data);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Veri tabanına eklerken bir hata oluştu");

            return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = portfoliomanager.GetByPortfolioID(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Portfolio data)
        {
           
            if (data.UploadImage==null)
            {
                portfoliomanager.PortfolioUpdate(data);
                return RedirectToAction("Index");
            }
            else
            {
                var uzanti = Path.GetExtension(data.UploadImage.FileName);
                var newname = Guid.NewGuid() + uzanti;
                var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                var stream = new FileStream(uploadstream, FileMode.Create);
                data.UploadImage.CopyTo(stream);

                portfoliomanager.PortfolioImageUpdate(data);
                return RedirectToAction("Index");
            }
           
        }
        public IActionResult Delete(Portfolio data)
        {
            portfoliomanager.PortfolioDelete(data);
            return RedirectToAction("Index");
        }
    }
}
