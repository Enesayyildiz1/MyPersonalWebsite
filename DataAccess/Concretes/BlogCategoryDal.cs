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
    public class BlogCategoryDal : EfEntityRepositoryBase<BlogCategory, MyPersonalSiteContext>, IBlogCategoryDal
    {
        public IEnumerable<BlogCategoryDto> GetBlogCategoryDetail(int id)
        {
            using (MyPersonalSiteContext db = new MyPersonalSiteContext())
            {
                var result = from bc in db.BlogCategories
                             join c in db.Categories
                             on bc.CategoryId equals c.Id
                             join b in db.Blogs
                             on bc.BlogId equals b.Id
                             select new BlogCategoryDto
                             { BlogId = bc.BlogId, BlogHead = b.BlogHead, CategoryId = bc.CategoryId, CategoryName = c.CategoryName };
                return result.ToList().Where(x => x.BlogId == id);


            }
        }
    }
}
