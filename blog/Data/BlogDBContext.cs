using blog.Models;
using Microsoft.EntityFrameworkCore;

namespace blog.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {
        }
        public DbSet<Blog> Blog { get; set; }
    }
}
