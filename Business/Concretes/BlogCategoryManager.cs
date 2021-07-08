﻿using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Concretes;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class BlogCategoryManager : IBlogCategoryService
    {
        private BlogCategoryDal _blogCategoryDal;

        public BlogCategoryManager(BlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public IResult Add(BlogCategory blogCategory)
        {
            _blogCategoryDal.Add(blogCategory);
            return new SuccessResult();
        }

        public IDataResult<List<BlogCategory>> GetAll()
        {
            return new SuccessDataResult<List<BlogCategory>>(_blogCategoryDal.GetAll());
        }
    }
}