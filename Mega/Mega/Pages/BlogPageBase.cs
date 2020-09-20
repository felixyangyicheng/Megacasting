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
        //protected override Task OnInitializedAsync()
        //{
        //    LoadBlogs();
        //    return base.OnInitializedAsync();
        //}


        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadBlogs);
        }

        private void LoadBlogs()
        {
            System.Threading.Thread.Sleep(2000);
            // Retrieve data from the server and initialize
            // Employees property which the View will bind
        }

     
    }
}
