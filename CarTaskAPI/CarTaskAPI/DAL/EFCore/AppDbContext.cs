using CarTaskAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarTaskAPI.DAL.EFCore;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Model> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }
}
