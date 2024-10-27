using Microsoft.EntityFrameworkCore;
using PhotoAPI.Models;

namespace PhotoAPI.Data;

public class PhotoApiContext(DbContextOptions<PhotoApiContext> options) : DbContext(options)
{
    public DbSet<UserModel> Users { get; set; } = null!;
}
