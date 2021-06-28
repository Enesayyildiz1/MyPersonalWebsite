using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class AboutImageManager : IAboutImageService
    {
        private IAboutImageDal _aboutImageDal;

        public AboutImageManager(IAboutImageDal aboutImageDal)
        {
            _aboutImageDal = aboutImageDal;
        }

        public IDataResult<List<AboutImage>> GetAll()
        {
            return new SuccessDataResult<List<AboutImage>>(_aboutImageDal.GetAll());
        }
    }
}
