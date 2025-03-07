using Microsoft.EntityFrameworkCore;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Article> Articles{ get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Image> Images { get; set; } 
    }
}
