using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Destination>()
          .HasData(
            new Destination { DestinationId = 1, Name = "Space Needle", State = "Washington", Country = "United States", Description = "Built in the 1960s for the world fair", Rating = 8 },
            new Destination { DestinationId = 2, Name = "Portland", State = "Oregon", Country = "United States", Description = "Home of the trailblazers", Rating = 8 },
            new Destination { DestinationId = 3, Name = "Vancouver", State = "British Columbia", Country = "Canada", Description = "Canada's Seattle", Rating = 7 }
          );

          builder.Entity<User>()
          .HasData(
            new User { Id = 1, Username = "Joe", Password = "test"},
            new User { Id = 2, Username = "Matt", Password = "test"}
          );
        }
    }
}