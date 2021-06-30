using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new BlogDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BlogList()
        {
            var blogs = _blogManager.GetAll().Data;

            return View(blogs);
        }
    }
}
