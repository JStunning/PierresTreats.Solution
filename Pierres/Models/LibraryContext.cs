using Microsoft.EntityFrameworkCore;

namespace Pierres.Models
{
  public class PierresContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public PierresContext(DbContextOptions options) : base(options) { }
  }
}