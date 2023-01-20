using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{

  public class NationalParksContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public NationalParksContext(DbContextOptions<NationalParksContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
      .HasData(
              new Park { ParkId = 1, ParkName = "Zion", Region = "Mountain", StateName = "Utah", Rating = 5 },
              new Park { ParkId = 2, ParkName = "Bryce Canyon", Region = "Mountain", StateName = "Utah", Rating = 4 },
              new Park { ParkId = 3, ParkName = "Crater Lake", Region = "Pacific West", StateName = "Oregon", Rating = 4 },
              new Park { ParkId = 4, ParkName = "Mount Rainier", Region = "Pacific West", StateName = "Washington", Rating = 4 },
              new Park { ParkId = 5, ParkName = "Denali", Region = "Pacific West", StateName = "Alaska", Rating = 5 },
              new Park { ParkId = 6, ParkName = "Acadia", Region = "Northeast", StateName = "Maine", Rating = 3 },
              new Park { ParkId = 7, ParkName = "Badlands", Region = "Midwest", StateName = "South Dakota", Rating = 2 }
      );
    }
  }
}