using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
	public class WorldModel
	{
		private readonly List<LocationModel> _locations = new();

		internal void AddLocation(string name, string description, string image, int xCoordinate, int yCoordinate)
		{
			LocationModel location = new()
			{
				Name = name,
				Description = description,
				Image = image,
				XCoordinate = xCoordinate,
				YCoordinate = yCoordinate
			};

			_locations.Add(location);
		}

		public LocationModel GetLocationAt(int xCoordinate, int yCoordinate)
		{
			foreach(LocationModel location in _locations) { if (location.XCoordinate == xCoordinate && location.YCoordinate == yCoordinate) return location; }

			return null;
		}
	}
}
