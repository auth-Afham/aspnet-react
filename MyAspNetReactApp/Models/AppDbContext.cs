// Models/AppDbContext.cs
using Microsoft.EntityFrameworkCore;

namespace MyAspNetReactApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

// Models/User.cs
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
