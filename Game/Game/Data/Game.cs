using System;
using System.Collections.Generic;

namespace Game.Data
{
	public class Game
	{
		public Guid Id { get; set; }
		public IList<GamePlayer> Players { get; set; }
	}
}
