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

        public IResult Add(Blog blog)
        {
            _blogDal.Add(blog);
            return new SuccessResult();
        }

        public IDataResult<List<Blog>> GetAll()
        {
          return new SuccessDataResult<List<Blog>>(  _blogDal.GetAll());
        }

        public IDataResult<Blog> GetByHeading(string name)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(x => x.BlogHead == name));
        }

        public IDataResult<Blog> GetById(int id)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(x => x.Id == id));
        }
    }
}
