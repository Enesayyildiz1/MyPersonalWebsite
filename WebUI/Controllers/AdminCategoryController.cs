using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Authorize]
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
        [HttpGet]
        public IActionResult GetCategoriesByBlogId(int id)
        {
            var liste = _blogCategoryManager.GetByBlogId(id).Data;
            return View(liste);
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryManager.Add(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var category=_categoryManager.GetById(id).Data;
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryManager.Update(category);
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
