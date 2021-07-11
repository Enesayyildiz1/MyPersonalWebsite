using Business.Abstracts;
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

        public IDataResult<List<BlogLabel>> GetByBlogId(int id)
        {
            return new SuccessDataResult<List<BlogLabel>>(_blogLabelDal.GetAll(x => x.BlogId == id));
        }

        public IResult Update(BlogLabel blogLabel)
        {
            _blogLabelDal.Update(blogLabel);
            return new SuccessResult();
        }
    }
}
