using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Concretes;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private CategoryDal _categoryDal;

        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
    }
}
