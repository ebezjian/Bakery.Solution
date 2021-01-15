using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Category> Flavors { get; set; }
    public DbSet<Item> Treats { get; set; }
    public DbSet<CategoryItem> FlavorTreat { get; set; }

    public BakeryContext(DbContextOptions options) : base(options) { }
  }
}