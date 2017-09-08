using System;

namespace Game.Data
{
	public class GamePlayer
	{
		public Guid Id { get; set; }
		public Player Player { get; set; }
		public Game Game { get; set; }
		public int Score { get; set; }
		public int Rank { get; set; }
	}
}
