using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Concretes;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class LabelManager : ILabelService
    {
        private LabelDal _labelDal;

        public LabelManager(LabelDal labelDal)
        {
            _labelDal = labelDal;
        }

        public IResult Add(Label label)
        {
            _labelDal.Add(label);
            return new SuccessResult();
        }

        public IDataResult<List<Label>> GetAll()
        {
            return new SuccessDataResult<List<Label>>(_labelDal.GetAll());
        }

        public IDataResult<Label> GetById(int id)
        {
            return new SuccessDataResult<Label>(_labelDal.Get(x=>x.Id==id));
        }

        public IResult Update(Label label)
        {
            _labelDal.Update(label);
            return new SuccessResult();
        }
    }
}
