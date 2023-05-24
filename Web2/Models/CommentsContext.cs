using Microsoft.EntityFrameworkCore;

namespace Web2.Models;

public class CommentsContext : DbContext
{
    public DbSet<Comment> Comments { get; set; } = null!;

    public CommentsContext(DbContextOptions<CommentsContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}