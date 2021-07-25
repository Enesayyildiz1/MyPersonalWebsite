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
    public class AdminLabelController : Controller
    {
        LabelManager _labelManager = new LabelManager(new LabelDal());
        BlogLabelManager _blogLabelManager = new BlogLabelManager(new BlogLabelDal());

        public IActionResult Index()
        {
         var list=   _labelManager.GetAll().Data;
            return View(list);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Label label)
        {
            _labelManager.Add(label);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Label label)
        {
            _labelManager.Update(label);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetLabelsByBlogId(int id)
        {
           var liste= _blogLabelManager.GetByBlogId(id).Data;
            return View(liste);
        }
        public IActionResult AddToBlog(int id)
        {
            BlogLabel blogLabel = new BlogLabel();
            List<SelectListItem> labels = (from category in _labelManager.GetAll().Data
                                               select new SelectListItem
                                               {
                                                   Text = category.LabelName,
                                                   Value = category.Id.ToString()
                                               }).ToList();
            ViewBag.liste = labels;
            blogLabel.Id = 0;
            blogLabel.BlogId = id;
            blogLabel.LabelId = 1;
            return View(blogLabel);
        }
        [HttpPost]
        public IActionResult AddToBlog(BlogLabel blogLabel)
        {
            blogLabel.Id = 0;
            _blogLabelManager.Add(blogLabel);
            return RedirectToAction("Index");
        }
    }
}
