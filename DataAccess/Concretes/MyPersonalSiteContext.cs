using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes
{
    public class MyPersonalSiteContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-7HDI1FAU;Database=Db_PersonalWebSite;" +
                "Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
    }
}
