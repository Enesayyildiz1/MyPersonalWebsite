using Core.DataAccess;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstracts
{
    public interface IBlogCategoryDal : IEntityRepository<BlogCategory>
    {
        IEnumerable<BlogCategoryDto> GetBlogCategoryDetail(int id);
    }
}
