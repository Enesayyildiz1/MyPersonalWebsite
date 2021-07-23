using Core.DataAccess;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
   public  interface IBlogLabelDal:IEntityRepository<BlogLabel>
    {
        IEnumerable<BlogLabelDto> GetBlogLabelDetail(int id);
    }
}
