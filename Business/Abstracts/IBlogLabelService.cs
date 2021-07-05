using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IBlogLabelService
    {
        IResult Add(BlogLabel blogLabel);
        IDataResult<List<BlogLabel>> GetAll();
    }
}
