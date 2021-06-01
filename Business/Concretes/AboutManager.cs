using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class AboutManager : IAboutService
    {
        private readonly  IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public DataResult<List<About>> GetAll()
        {
            
          return new SuccessDataResult<List<About>>(  _aboutDal.GetAll(),"Geldi");
        }
    }
}
