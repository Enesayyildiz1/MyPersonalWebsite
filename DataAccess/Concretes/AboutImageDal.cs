﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class AboutImageDal: EfEntityRepositoryBase<AboutImage,MyPersonalSiteContext>,IAboutImageDal
    {
    }
}
