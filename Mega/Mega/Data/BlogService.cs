using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mega.Data
{
    public class BlogService
    {
        private readonly BloggingContext _context;

        public  BlogService(BloggingContext context)
        {
            _context = context;
        }

        public List<Blog> GetBlog()
        {
            return _context.Blog.ToList() ;
        }
    }
}
