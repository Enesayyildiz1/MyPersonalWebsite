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
        BlogImageManager _blogImageManager = new BlogImageManager(new BlogImageDal());
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
        public IActionResult Add(BlogImageViewModel blogImageViewModel)
        {
            Blog blog = new Blog();
            BlogImage blogImage = new BlogImage();

            blogImage = blogImageViewModel.BlogImage;
            blog = blogImageViewModel.Blogs;

            blog.Author = "Enes Ayyıldız";
            blog.PublishedDate = DateTime.Now;
            _blogManager.Add(blog);
            var newBlog=_blogManager.GetByHeading(blog.BlogHead).Data;
            blogImage.Date = DateTime.Now;
            blogImage.BlogId = newBlog.Id;
            _blogImageManager.Add(blogImage);
            return RedirectToAction("Index");

        }
        public IActionResult BlogDetail(int id)
        {
            BlogImageViewModel blogImageViewModel = new BlogImageViewModel();
            var blogs = _blogManager.GetById(id).Data;
            var blogImages = _blogImageManager.GetByBlogId(id).Data;
            blogImageViewModel.Blogs = blogs;
            blogImageViewModel.BlogImage = blogImages;

            return View(blogImageViewModel);
        }
    }
}
