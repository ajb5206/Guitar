using Microsoft.EntityFrameworkCore;

namespace GuitarStuff.Models
{
	public class GuitarStuffContext : DbContext
	{
		public GuitarStuffContext(DbContextOptions<GuitarStuffContext> options) : base(options)
		{

		}

		public DbSet<Guitar> Guitars { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
{
  builder.Entity<Guitar>()
      .HasData(
          new Guitar { GuitarId = 1, GuitarType = "Matilda", GuitarPlayersAssociated = "Woolly Mammoth" },
          new Guitar { GuitarId = 2, GuitarType = "Rexie", GuitarPlayersAssociated = "Dinosaur" },
          new Guitar { GuitarId = 3, GuitarType = "Matilda", GuitarPlayersAssociated = "Dinosaur" },
          new Guitar { GuitarId = 4, GuitarType = "Pip", GuitarPlayersAssociated = "Shark"},
          new Guitar { GuitarId = 5, GuitarType = "Bartholomew", GuitarPlayersAssociated = "Dinosaur"}
      );
}
	}
}