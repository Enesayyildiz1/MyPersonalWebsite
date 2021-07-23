using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Concretes;
using Entity.Concrete;
using Entity.Dtos;
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

        public IDataResult<IEnumerable<BlogLabelDto>> GetByBlogId(int id)
        {
            return new SuccessDataResult<IEnumerable<BlogLabelDto>>(_blogLabelDal.GetBlogLabelDetail(id));
        }

        public IResult Update(BlogLabel blogLabel)
        {
            _blogLabelDal.Update(blogLabel);
            return new SuccessResult();
        }
    }
}
