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
    public class AdminBlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new BlogDal());
        public AdminBlogController(IMapper mapper)
        {
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
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
        public IActionResult Add(BlogImageInfo blogImageInfo)
        {
            Blog blog = new Blog() ;
            blogImageInfo.Author = "Enes Ayyıldız";
            blogImageInfo.PublishedDate = DateTime.Now;


            string fileName = Path.GetFileNameWithoutExtension(blogImageInfo.Image.FileName);
            string extension = Path.GetExtension(blogImageInfo.Image.FileName);
            string newImageName = Guid.NewGuid() + extension;
            string path = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/uploads/" + newImageName);

            var stream = new FileStream(path, FileMode.Create);
            blogImageInfo.Image.CopyTo(stream);


            blog.PublishedDate = blogImageInfo.PublishedDate;
            blog.ReadTime = blogImageInfo.ReadTime;
            blog.BlogHead = blogImageInfo.BlogHead;
            blog.BlogBody = blogImageInfo.BlogBody;
            blog.Author = blogImageInfo.Author;
            
            blog.ImagePath = "/uploads/" + newImageName;   
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
