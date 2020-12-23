using Project.ThesisBlog.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ThesisBlog.Entities.Concrete
{
    public class ThesisUser : ITablo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        List<Blog> Blogs { get; set; }
        
    }
}
