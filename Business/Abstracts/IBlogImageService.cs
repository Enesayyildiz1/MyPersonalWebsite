using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
   public  interface IBlogImageService
    {
        IDataResult<BlogImage> GetByBlogId(int id);
        IResult Add(BlogImage blogImage);
    }
}
