using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager _categoryManager = new CategoryManager(new CategoryDal());
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
    }
}
