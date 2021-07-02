using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class BlogManager : IBlogService
    {
       private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public IDataResult<List<Blog>> GetAll()
        {
          return new SuccessDataResult<List<Blog>>(  _blogDal.GetAll());
        }

        public IDataResult<Blog> GetById(int id)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(x => x.Id == id));
        }
    }
}
