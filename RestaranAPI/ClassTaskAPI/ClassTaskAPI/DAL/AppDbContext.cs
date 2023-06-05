using ClassTaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassTaskAPI.DAL;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
	{

	}
	public virtual DbSet<Product> Products { get; set; }
	public virtual DbSet<Restaran> Restaurants { get; set; }
}
