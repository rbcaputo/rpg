using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controllers.Session
{
	public class Session : INotifyPropertyChanged
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
			}
		}

		// Check world limits
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
			WorldFactory worldFactory = new();
			World = worldFactory.GenerateWorld();

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

		// Movement controls
		public void MoveNorth() { Location = World.GetLocationAt(Location.XCoordinate, Location.YCoordinate + 1); }
		public void MoveEast() { Location = World.GetLocationAt(Location.XCoordinate + 1, Location.YCoordinate); }
		public void MoveSouth() { Location = World.GetLocationAt(Location.XCoordinate, Location.YCoordinate - 1); }
		public void MoveWest() { Location = World.GetLocationAt(Location.XCoordinate - 1, Location.YCoordinate); }

		// Interface
		public event PropertyChangedEventHandler? PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); }
	}
}
