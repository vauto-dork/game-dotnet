using Microsoft.EntityFrameworkCore;

namespace Game.Data
{
	public class GameContext : DbContext
	{
		public DbSet<Player> Player { get; set; }
		public DbSet<Game> Game { get; set; }
		public DbSet<GamePlayer> GamePlayer { get; set; }

		public GameContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Game>()
				.HasKey(game => game.Id);
			modelBuilder.Entity<Player>()
				.HasKey(player => player.Id);
			modelBuilder.Entity<GamePlayer>()
				.HasKey(gamePlayer => gamePlayer.Id);
			modelBuilder.Entity<GamePlayer>()
				.HasOne(gamePlayer => gamePlayer.Player)
				.WithMany(player => player.History);
			modelBuilder.Entity<GamePlayer>()
				.HasOne(gamePlayer => gamePlayer.Game)
				.WithMany(player => player.Players);
		}
	}
}
