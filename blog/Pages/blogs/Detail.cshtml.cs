using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Pages.blogs
{
    public class DetailModel : PageModel
    {
        private readonly BlogDBContext _db;

        public DetailModel(BlogDBContext db)
        {
            _db = db;
        }
        public Blog Blog { get; set; }
        public void OnGet(int? id)
        {
            Blog = _db.Blog.Find(id);
        }
    }
}
