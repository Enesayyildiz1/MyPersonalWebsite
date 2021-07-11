using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ILabelService
    {
        IDataResult<List<Label>> GetAll();
        IResult Add(Label label);

      
        IDataResult<Label> GetById(int id);
        IResult Update(Label label);
    }
}
