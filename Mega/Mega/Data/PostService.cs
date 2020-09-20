using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mega.Data
{
    public class PostService
    {
        private readonly BloggingContext _context;

        public  PostService(BloggingContext context)
        {
            _context = context;
        }

        public List<Post> GetPost()
        {
            return _context.Post.ToList() ;
        }
    }
}
