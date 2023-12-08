using Engine.Factories;
using Engine.Models.General;
using Engine.Models.Quests;
using Engine.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controllers.Session
{
	public class Session : NotificationClass
	{
		// Backing variables
		private LocationModel _location;

		public WorldModel World { get; set; }
		public PlayerModel Player { get; set; }
		public LocationModel Location
		{
			get { return _location; }
			set
			{
				_location = value;
				OnPropertyChanged(nameof(Location));
				OnPropertyChanged(nameof(HasLocationToNorth));
				OnPropertyChanged(nameof(HasLocationToEast));
				OnPropertyChanged(nameof(HasLocationToSouth));
				OnPropertyChanged(nameof(HasLocationToWest));
				AssignLocationQuest();
			}
		}

		// Get world limits
		public bool HasLocationToNorth
		{
			get { return World.GetLocationAt(Location.XCoordinate, Location.YCoordinate + 1) != null; }
		}
		public bool HasLocationToEast
		{
			get { return World.GetLocationAt(Location.XCoordinate + 1, Location.YCoordinate) != null; }
		}
		public bool HasLocationToSouth
		{
			get { return World.GetLocationAt(Location.XCoordinate, Location.YCoordinate - 1) != null; }
		}
		public bool HasLocationToWest
		{
			get { return World.GetLocationAt(Location.XCoordinate - 1, Location.YCoordinate) != null; }
		}

		public Session()
		{
			// Current world
			World = WorldFactory.GenerateWorld();

			// Current player
			Player = new()
			{
				Name = "Player name",
				Race = "Player race",
				Class = "Player class",
				Level = 1,
				Experience = 0,
				Gold = 0,
				Strength = 1,
				Dexterity = 1,
				Constitution = 1,
				Intelligence = 1,
				Wisdom = 1,
				Charisma = 1
			};

			// Current location
			Location = World.GetLocationAt(0, 0);
		}

		// Quests handling
		private void AssignLocationQuest()
		{
			foreach(QuestModel quest in Location.Quests) { if (!Player.Quests.Any(qst => qst.Quest.ID == quest.ID)) Player.Quests.Add(new QuestStatus(quest)); }
		}

		// Movement controls
		public void MoveNorth() { if (HasLocationToNorth) Location = World.GetLocationAt(Location.XCoordinate, Location.YCoordinate + 1); }
		public void MoveEast() { if (HasLocationToEast) Location = World.GetLocationAt(Location.XCoordinate + 1, Location.YCoordinate); }
		public void MoveSouth() { if (HasLocationToSouth) Location = World.GetLocationAt(Location.XCoordinate, Location.YCoordinate - 1); }
		public void MoveWest() { if (HasLocationToWest) Location = World.GetLocationAt(Location.XCoordinate - 1, Location.YCoordinate); }
	}
}
