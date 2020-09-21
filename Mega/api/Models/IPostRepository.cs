using System;
using System.Collections.Generic;
using System.Text;
using model;

namespace api.Models
{
   public  interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
        Post GetPost(int postId);
    }
}
