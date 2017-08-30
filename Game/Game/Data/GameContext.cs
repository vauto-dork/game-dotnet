using Microsoft.EntityFrameworkCore;

namespace Game.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Player { get; set; }

        public GameContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasKey(data => data.Id);
        }
    }
}
