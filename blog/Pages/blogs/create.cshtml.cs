using blog.Data;
using blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Pages.blogs
{
    public class createModel : PageModel
    {
        private readonly BlogDBContext _db;

        public createModel(BlogDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blog Blog { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Blog.AddAsync(Blog);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
