using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        BlogManager _blogManager = new BlogManager(new BlogDal());
        CategoryManager _categoryManager = new CategoryManager(new CategoryDal());
        LabelManager _labelManager = new LabelManager(new LabelDal());
        public IActionResult Index()
        {
            var blogs = _blogManager.GetAll().Data;
            return View(blogs);
        }
       

    
    }
}
