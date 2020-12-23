using Project.ThesisBlog.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ThesisBlog.Entities.Concrete
{
    public class Blog: ITablo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
