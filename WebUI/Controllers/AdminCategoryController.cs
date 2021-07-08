using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new CategoryDal());
        BlogCategoryManager _blogCategoryManager = new BlogCategoryManager(new BlogCategoryDal());
        public IActionResult Index()
        {
           var liste= _categoryManager.GetAll().Data;
            return View(liste);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryManager.Add(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddToBlog(int id)
        {
            BlogCategory blogCategory = new BlogCategory();
            List<SelectListItem> categories = (from category in _categoryManager.GetAll().Data
                                          select new SelectListItem
                                          {
                                              Text = category.CategoryName,
                                              Value = category.Id.ToString()
                                          }).ToList();
            ViewBag.liste = categories;
            blogCategory.Id = 0;
            blogCategory.BlogId = id;
            blogCategory.CategoryId = 1;
            return View(blogCategory);
        }
        [HttpPost]
        public IActionResult AddToBlog(BlogCategory blogCategory)
        {
            blogCategory.Id = 0;
            _blogCategoryManager.Add(blogCategory);
            return RedirectToAction("Index");
        }
    }
}
