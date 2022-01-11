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
    public class AdminTeamController : Controller
    {
        TeamManager teammanager = new TeamManager();
        public IActionResult Index()
        {
            var list = teammanager.List();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team data)
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
                    teammanager.TeamAdd(data);
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError("", "Veri tabanına eklerken bir hata oluştu");
            
           return View(data);
        }
        public IActionResult Update(int id)
        {
            var update = teammanager.GetByTeamID(id);
            return View(update);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Team data)
        {
            if (data.UploadImage!=null)
            {
                var update = teammanager.GetByTeamID(data.Id);
                var uzanti = Path.GetExtension(data.UploadImage.FileName);
                var newname = Guid.NewGuid() + uzanti;
                var uploadstream = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + newname);
                var stream = new FileStream(uploadstream, FileMode.Create);
                data.UploadImage.CopyTo(stream);
               
                teammanager.TeamImageUpdate(data);
                return RedirectToAction("Index");
            }
            else
            {
                teammanager.TeamUpdate(data);
                return RedirectToAction("Index");
            }
           
        }
        public IActionResult Delete(Team data)
        {
            teammanager.TeamDelete(data);
            return RedirectToAction("Index");

        }

    }
}
