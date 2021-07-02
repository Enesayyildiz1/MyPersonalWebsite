using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class BlogImageManager : IBlogImageService
    {
        private readonly IBlogImageDal _blogImageDal;

        public BlogImageManager(IBlogImageDal blogImageDal)
        {
            _blogImageDal = blogImageDal;
        }

        public IDataResult<BlogImage> GetByBlogId(int id)
        {
            return new SuccessDataResult<BlogImage>(_blogImageDal.Get(x => x.BlogId == id));
        }
    }
}
