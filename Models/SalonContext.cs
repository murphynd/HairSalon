using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public virtual DbSet<Client> Clients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}
