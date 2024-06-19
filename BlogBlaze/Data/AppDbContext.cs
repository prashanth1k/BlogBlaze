using Microsoft.EntityFrameworkCore;
using BlogBlaze.Models;

namespace BlogBlaze.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Post> Posts { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
    {
    }
  }
}