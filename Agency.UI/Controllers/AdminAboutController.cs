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
    public class AdminAboutController : Controller
    {
        AboutManager aboutmanager = new AboutManager();
        public IActionResult Index()
        {
            var list = aboutmanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(About data)
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

                    aboutmanager.AboutAdd(data);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Veri tabanına eklenirken bir hata oluştu");
            return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = aboutmanager.GetByAboutID(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(About data)
        {
            if (data.UploadImage!=null)
            {
                var uzanti = Path.GetExtension(data.UploadImage.FileName);
                var newname = Guid.NewGuid() + uzanti;
                var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                var stream = new FileStream(uploadstream, FileMode.Create);
                data.UploadImage.CopyTo(stream);
                data.Image = newname;

                aboutmanager.AboutAdd(data);
                return RedirectToAction("Index");
            }
            else
            {

                aboutmanager.AboutAdd(data);
                return RedirectToAction("Index");
            }

           
           
        }
    }
}
