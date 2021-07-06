using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
   public  interface IBlogService
    {
        IDataResult<List<Blog>> GetAll();
        IDataResult<Blog> GetById(int id);
        IDataResult<Blog> GetByHeading(string name);
        IResult Add(Blog blog);
    }
}
