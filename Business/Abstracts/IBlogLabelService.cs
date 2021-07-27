using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBlogLabelService
    {
        IResult Add(BlogLabel blogLabel);
        IDataResult<List<BlogLabel>> GetAll();
        IDataResult<IEnumerable<BlogLabelDto>> GetByBlogId(int id);
        IDataResult<IEnumerable<BlogLabelDto>> GetByLabelId(int id);
        IResult Update(BlogLabel blogLabel);
    }
}
