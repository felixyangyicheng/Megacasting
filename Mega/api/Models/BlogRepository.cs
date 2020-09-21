using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using model;

namespace api.Models
{
    public class BlogRepository:IBlogRepository
    {
        private readonly BloggingContext bloggingContext;

        public BlogRepository(BloggingContext bloggingContext)
        {
            this.bloggingContext = bloggingContext;
        }

        public async Task<Blog> GetBlog(int blogID)
        {
            return await bloggingContext.Blog.FirstOrDefaultAsync(b => b.BlogId == blogID);        
        }

        public async Task<Blog> AddBlog(Blog blog)
        {
            var result = await bloggingContext.Blog.AddAsync(blog);
            await bloggingContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Blog> UpdateBlog(Blog blog)
        {
            var result = await bloggingContext.Blog.FirstOrDefaultAsync(b => b.BlogId == blog.BlogId);
            if (result != null)
            {
                result.BlogId = blog.BlogId;
                result.Url = blog.Url;

                await bloggingContext.SaveChangesAsync();
                
                return result;
            }
            else
            {
                return null;
            }

        }

        public async void DeleteBlog(int blogID)
        {
            var result = await bloggingContext.Blog.FirstOrDefaultAsync(b => b.BlogId == blogID);
            if (result != null)
            {
                bloggingContext.Blog.Remove(result);
                await bloggingContext.SaveChangesAsync();
            }
            
        }
    }
}
