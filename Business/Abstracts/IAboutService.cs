using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IAboutService
    {
        IDataResult<List<About>> GetAll();
        IResult Update(About about);
    }
}
