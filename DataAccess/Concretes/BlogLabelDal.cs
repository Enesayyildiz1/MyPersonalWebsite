using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concrete;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concretes
{
    public class BlogLabelDal:EfEntityRepositoryBase<BlogLabel,MyPersonalSiteContext>,IBlogLabelDal
    {
        public IEnumerable<BlogLabelDto> GetBlogLabelDetail(int id)
        {
            using (MyPersonalSiteContext db = new MyPersonalSiteContext())
            {
                var result = from bl in db.BlogLabels
                             join l in db.Labels
                             on bl.LabelId equals l.Id
                             join b in db.Blogs
                             on bl.BlogId equals b.Id
                             select new BlogLabelDto
                             { BlogId = bl.BlogId, BlogHead = b.BlogHead, LabelId = bl.LabelId, LabelName = l.LabelName };
                return result.ToList().Where(x=>x.BlogId==id);

                          
            }

        }
    }
}
