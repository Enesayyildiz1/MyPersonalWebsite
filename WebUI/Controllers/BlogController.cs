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
        BlogCategoryManager _blogCategoryManager = new BlogCategoryManager(new BlogCategoryDal());
        BlogLabelManager _blogLabelManager = new BlogLabelManager(new BlogLabelDal());

        public IActionResult Index(int id)
        {
          
            var blogs = _blogManager.GetById(id).Data;
           

            return View(blogs);
        }
        
        public IActionResult BlogList()
        {
            var blogs = _blogManager.GetAll().Data;

            return View(blogs);
        }
        public IActionResult GetBlogsByCategoryId(int id)
        {
            var blogs = _blogCategoryManager.GetByCategoryId(id).Data;
            return View(blogs);
        }
        public IActionResult GetBlogsByLabelId(int id)
        {
            var blogs = _blogLabelManager.GetByLabelId(id).Data;
            return View(blogs);
        }
    }
}
