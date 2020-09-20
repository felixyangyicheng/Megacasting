using Microsoft.AspNetCore.Components;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mega.Pages
{
    public class BlogPageBase:ComponentBase
    {
        public IEnumerable<Blog> Blogs { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadBlogs();
            return base.OnInitializedAsync();
        }

        private void LoadBlogs()
        {

        }
    }
}
