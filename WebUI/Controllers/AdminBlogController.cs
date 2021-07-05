using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminBlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new BlogDal());
        public IActionResult Index()
        {
           var liste= _blogManager.GetAll().Data;
            return View(liste);
        }
    }
}
