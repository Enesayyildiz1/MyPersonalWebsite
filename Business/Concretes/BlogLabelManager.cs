﻿using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Concretes;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class BlogLabelManager : IBlogLabelService
    {
        private BlogLabelDal _blogLabelDal;

        public BlogLabelManager(BlogLabelDal blogLabelDal)
        {
            _blogLabelDal = blogLabelDal;
        }

        public IResult Add(BlogLabel blogLabel)
        {
            _blogLabelDal.Add(blogLabel);
            return new SuccessResult();
        }

        public IDataResult<List<BlogLabel>> GetAll()
        {
            return new SuccessDataResult<List<BlogLabel>>(_blogLabelDal.GetAll());
        }
    }
}
