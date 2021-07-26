using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class CategoriesAndLabelsList:ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new CategoryDal());
        LabelManager _labelManager = new LabelManager(new LabelDal());
        public IViewComponentResult Invoke()
        {
            var categories = _categoryManager.GetAll().Data;
            var labels = _labelManager.GetAll().Data;
            CategoryLabelViewModel model = new CategoryLabelViewModel();
            model.Categories = categories;
            model.Labels = labels;
            return View(model);
        }
    }
}
