using AutoMapper;
using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    [Authorize]
    public class AdminAboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager(new AboutDal());

        public AdminAboutController(IMapper mapper)
        {
            _mapper = mapper;
        }

        private readonly IMapper _mapper;


        public IActionResult Index()
        {
            var liste = _aboutManager.GetAll().Data.FirstOrDefault();
            var aboutInfo = _mapper.Map<AboutProfileInfo>(liste);
            return View(aboutInfo);
        }
        public IActionResult Update(AboutProfileInfo aboutProfile)
        {
            var about = _aboutManager.GetAll().Data.FirstOrDefault();
           
                
                string fileName = Path.GetFileNameWithoutExtension(aboutProfile.FirstImage.FileName);
                string extension = Path.GetExtension(aboutProfile.FirstImage.FileName);
                string newImageName = Guid.NewGuid() + extension;
                string path = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/uploads/" + newImageName);
               
                var stream = new FileStream(path, FileMode.Create);
                aboutProfile.FirstImage.CopyTo(stream);


            string file2Name = Path.GetFileNameWithoutExtension(aboutProfile.SecondImage.FileName);
            string extension2 = Path.GetExtension(aboutProfile.SecondImage.FileName);
            string newImageName2 = Guid.NewGuid() + extension2;
            string path2 = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/uploads/" + newImageName2);

            var stream2 = new FileStream(path2, FileMode.Create);
            aboutProfile.SecondImage.CopyTo(stream2);



            var aboutChanged = _mapper.Map(aboutProfile, about);
            aboutChanged.FirstImagePath = "/uploads/"+newImageName;
            aboutChanged.SecondImagePath = "/uploads/" + newImageName2;

            _aboutManager.Update(aboutChanged);
            return RedirectToAction("Index");
        }

    }
}
