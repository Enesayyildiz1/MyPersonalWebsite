using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

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
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

            [HttpPost]
        public IActionResult Add(Blog blog)
        {           
            blog.Author = "Enes Ayyıldız";
            blog.PublishedDate = DateTime.Now;
            _blogManager.Add(blog);              
            return RedirectToAction("Index");

        }
        public IActionResult BlogDetail(int id)
        {
           
            var blogs = _blogManager.GetById(id).Data;           
            return View(blogs);
        }
        public IActionResult BlogAddCategoryOrLabel()
        {
            var liste = _blogManager.GetAll().Data;
            return View(liste);
        }
    }
}
