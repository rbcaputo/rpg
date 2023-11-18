using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
	internal class WorldFactory
	{
		internal WorldModel GenerateWorld()
		{
			WorldModel world = new();

			world.AddLocation("Firecamp", "Your group's firecamp", "pack://application:,,,/Engine;component/Images/Locations/Firecamp.png", 0, 0);
			world.AddLocation("Oasis", "An oasis with an abandoned tent", "pack://application:,,,/Engine;component/Images/Locations/Oasis.png", 0, 1);

			return world;
		}
	}
}
