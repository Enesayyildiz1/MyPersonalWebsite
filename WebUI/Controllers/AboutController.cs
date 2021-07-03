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
       

        public IActionResult Index()
        {
            
            
            var about= _aboutService.GetAll().Data.FirstOrDefault();
           
          
            return View(about);
        }
        
    }
}
