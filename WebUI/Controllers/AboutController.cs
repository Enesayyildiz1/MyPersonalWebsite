using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutService = new AboutManager(new AboutDal());
        AboutImageManager _aboutImageService = new AboutImageManager(new AboutImageDal());

        public IActionResult Index()
        {
            AboutImageViewModel model = new AboutImageViewModel();
            var images = _aboutImageService.GetAll();
            var about= _aboutService.GetAll().Data.FirstOrDefault();
            model.Abouts = about;
            model.AboutImages = images.Data;
            return View(model);
        }
    }
}
