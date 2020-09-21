using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
   public  interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
        Post GetPost(int postId);
    }
}
