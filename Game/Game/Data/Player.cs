using System;
using System.Collections.Generic;

namespace Game.Data
{
	public class Player
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NickName { get; set; }
		public string CustomInitials { get; set; }
		public bool Active { get; set; }
		public IList<GamePlayer> History { get; set; }

		public Player(Guid id, string firstName, string lastName, string nickName, string customInitials, bool active)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			NickName = nickName;
			CustomInitials = customInitials;
			Active = active;
		}

		public Player() { }
	}
}
