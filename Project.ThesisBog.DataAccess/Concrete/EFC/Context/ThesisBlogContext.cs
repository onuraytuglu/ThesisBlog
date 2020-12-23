using Microsoft.EntityFrameworkCore;
using Project.ThesisBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ThesisBog.DataAccess.Concrete.EFC.Context
{
    public class ThesisBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localdb)\\mssqlocaldb; database=ThesisBlog; user id=sa password=1;");
        }

        public DbSet<ThesisUser> ThesisUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<CategoryBlog> CategoryBlogs{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
    }
}
