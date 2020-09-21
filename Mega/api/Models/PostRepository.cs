using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using model;

namespace api.Models
{
    public class PostRepository:IPostRepository
    {
        private readonly BloggingContext bloggingContext;

        public PostRepository(BloggingContext bloggingContext)
        {
            this.bloggingContext = bloggingContext;
        }

        public Post GetPost(int postId)
        {
            return bloggingContext.Post
                .FirstOrDefault(p => p.PostId == postId);
        }

        public IEnumerable<Post> GetPosts()
        {
            return bloggingContext.Post;
        }
    }
}
