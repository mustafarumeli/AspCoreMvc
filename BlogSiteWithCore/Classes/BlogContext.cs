using BlogSiteWithCore.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogSiteWithCore.Classes
{
    public class BlogContext : DbContext
    {
        public BlogContext (DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }
    }


}
