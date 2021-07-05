using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBlogCategoryService
    {
        IDataResult<List<BlogCategory>> GetAll();
        IResult Add(BlogCategory blogCategory);
    }
}
