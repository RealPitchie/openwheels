using Microsoft.EntityFrameworkCore;

namespace yapf1.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Longread> Longreads { get; set; }
        
    }
}