using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new AboutDal());
        
        public IActionResult Index()
        {
          var liste=  _aboutManager.GetAll().Data.FirstOrDefault();
            return View(liste);
        }
        public IActionResult Update(About about)
        {
            _aboutManager.Update(about);
            return RedirectToAction("Index");
        }
     
    }
}
