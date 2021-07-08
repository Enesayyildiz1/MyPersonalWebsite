using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new AboutDal());
        
        

        public IActionResult Index()
        {
            var liste = _aboutManager.GetAll().Data.FirstOrDefault();
            return View(liste);
        }
        public IActionResult Update(About about)
        {
            if (ModelState.IsValid)
            {
                
                string fileName = Path.GetFileNameWithoutExtension(about.FirstImagePath);
                string extension = Path.GetExtension(about.FirstImagePath);
                string newImageName = Guid.NewGuid() + extension;
                string path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/uploads/" + newImageName);
                FileInfo fi1 = new FileInfo(about.FirstImagePath);
                var stream = new FileStream(path, FileMode.Create);
                about.FirstImagePath.CopyTo(stream);
               
            }

            _aboutManager.Update(about);
            return RedirectToAction("Index");
        }

    }
}
