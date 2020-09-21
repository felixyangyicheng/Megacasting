using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetBlogs(); // Get tous les blogs
        Task<Blog> GetBlog(int BlogId); // Get un seul blog avec BlogId
        Task<Blog> AddBlog(Blog blog);  // Ajouter un nouveau blog
        Task<Blog> UpdateBlog(Blog blog); // Mettre à jour le nouveau blog  
        void DeleteBlog(int blogId); // Supprimer un blog par BlogId
    }
}
