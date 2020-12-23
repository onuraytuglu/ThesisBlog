using Project.ThesisBlog.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ThesisBlog.Entities.Concrete
{
    public class CategoryBlog: ITablo
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }
}
