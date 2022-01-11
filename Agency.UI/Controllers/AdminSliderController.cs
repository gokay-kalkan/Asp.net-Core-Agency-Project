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
    [Authorize(Roles = "admin")]
    public class AdminSliderController : Controller
    {
        SliderManager slidermanager = new SliderManager();

        public IActionResult Index()
        {
            var list = slidermanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider data)
        {
            if (data.UploadImage!=null)
            {
                var uzanti = Path.GetExtension(data.UploadImage.FileName);
                var newname = Guid.NewGuid() + uzanti;
                var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                var stream = new FileStream(uploadstream, FileMode.Create);
                data.UploadImage.CopyTo(stream);
                data.Image = newname;

                slidermanager.SliderAdd(data);
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = slidermanager.GetBySliderID(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Slider data)
        {
            var update = slidermanager.GetBySliderID(data.Id);
            var uzanti = Path.GetExtension(data.UploadImage.FileName);
            var newname = Guid.NewGuid() + uzanti;
            var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
            var stream = new FileStream(uploadstream, FileMode.Create);
            data.UploadImage.CopyTo(stream);
            update.Image = newname;
            slidermanager.SliderUpdate(data);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Slider data)
        {

            slidermanager.SliderDelete(data);
            return RedirectToAction("Index");
        }
    }
}
