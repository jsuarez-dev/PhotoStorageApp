using Microsoft.EntityFrameworkCore;
using PhotoAPI.Models;

namespace PhotoAPI.Data;

public class PhotoApiContext(DbContextOptions<PhotoApiContext> options) : DbContext(options)
{
    public DbSet<UserModel> User { get; set; } = null!;
    public DbSet<PhotoModel> Photo { get; set; } = null!;
}
