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
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new BlogDal());
        BlogImageManager _blogImageManager = new BlogImageManager(new BlogImageDal());
        
        public IActionResult Index(int id)
        {
            BlogImageViewModel blogImageViewModel = new BlogImageViewModel();
            var blogs = _blogManager.GetById(id).Data;
            var blogImages = _blogImageManager.GetByBlogId(id).Data;
            blogImageViewModel.Blogs = blogs;
            blogImageViewModel.BlogImage = blogImages;

            return View(blogImageViewModel);
        }
        
        public IActionResult BlogList()
        {
            var blogs = _blogManager.GetAll().Data;

            return View(blogs);
        }
    }
}
