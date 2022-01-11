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
    public class AdminClientsController : Controller
    {
        ClientsManager clientsmanager = new ClientsManager();
        public IActionResult Index()
        {
            var list = clientsmanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Clients data)
        {
            if (data.UploadImage!=null)
            {
                var uzanti = Path.GetExtension(data.UploadImage.FileName);
                var newname = Guid.NewGuid() + uzanti;
                var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                var stream = new FileStream(uploadstream, FileMode.Create);
                data.UploadImage.CopyTo(stream);
                data.Image = newname;
                clientsmanager.ClientsAdd(data);
                return RedirectToAction("Index");
            }
            return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = clientsmanager.GetByClientsID(id);

            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Clients data)
        {
            var update = clientsmanager.GetByClientsID(data.Id);
            var uzanti = Path.GetExtension(data.UploadImage.FileName);
            var newname = Guid.NewGuid() + uzanti;
            var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
            var stream = new FileStream(uploadstream, FileMode.Create);
            data.UploadImage.CopyTo(stream);
            update.Image = newname;
            clientsmanager.ClientsUpdate(data);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Clients data)
        {
            clientsmanager.ClientsDelete(data);
            return RedirectToAction("Index");
        }
    }
}
