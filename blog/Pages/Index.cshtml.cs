using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogDBContext _db;
        public IndexModel(BlogDBContext db)
        {
            _db = db;
        }
        public IEnumerable<Blog> Blog { get; set; }

        //private readonly ILogger<IndexModel> _logger;
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public void OnGet()
        {
            Blog = _db.Blog;
        }
    }
}
