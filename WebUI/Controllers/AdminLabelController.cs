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
    public class AdminLabelController : Controller
    {
        LabelManager _labelManager = new LabelManager(new LabelDal());

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
    }
}
