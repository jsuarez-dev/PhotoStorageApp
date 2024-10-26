using Microsoft.EntityFrameworkCore;

namespace PhotoAPI.Models;

public class PhotoAPIContext : DbContext
{
    public PhotoAPIContext(DbContextOptions<PhotoAPIContext> options)
        : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; } = null!;
}
