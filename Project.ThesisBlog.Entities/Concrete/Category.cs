using Project.ThesisBlog.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ThesisBlog.Entities.Concrete
{
    public class Category: ITablo
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
