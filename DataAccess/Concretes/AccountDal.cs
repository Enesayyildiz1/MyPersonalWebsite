using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class AccountDal: EfEntityRepositoryBase<User, MyPersonalSiteContext>, IAccountDal
    {
    }
}
