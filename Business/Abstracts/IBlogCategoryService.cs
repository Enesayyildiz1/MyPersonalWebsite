using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBlogCategoryService
    {
        IDataResult<List<BlogCategory>> GetAll();
        IResult Update(BlogCategory blogCategory);
        IDataResult<IEnumerable<BlogCategoryDto>> GetByBlogId(int id);
        IResult Add(BlogCategory blogCategory);
    }
}
