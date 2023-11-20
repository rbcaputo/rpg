using Engine.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class WorldFactory
	{
		internal static WorldModel GenerateWorld()
		{
			WorldModel world = new();

			world.AddLocation("Mountain range exit", "Mountain range exit", "pack://application:,,,/Engine;component/Images/Locations/-3,0.png", -3, 0);
			world.AddLocation("Mountain range entrance", "Mountain range entrance", "pack://application:,,,/Engine;component/Images/Locations/-2,0.png", -2, 0);
			world.AddLocation("Village", "Village", "pack://application:,,,/Engine;component/Images/Locations/-1,0.png", -1, 0);
			world.AddLocation("City", "Main city", "pack://application:,,,/Engine;component/Images/Locations/0,0.png", 0, 0);
			world.AddLocation("River", "Main river", "pack://application:,,,/Engine;component/Images/Locations/1,0.png", 1, 0);
			world.AddLocation("Forest entrance", "Forest entrance", "pack://application:,,,/Engine;component/Images/Locations/2,0.png", 2, 0);
			world.AddLocation("Forest", "Forest", "pack://application:,,,/Engine;component/Images/Locations/3,0.png", 3, 0);
			world.AddLocation("Forest's ravine", "Ravine", "pack://application:,,,/Engine;component/Images/Locations/4,0.png", 4, 0);

			world.AddLocation("River", "Main river", "pack://application:,,,/Engine;component/Images/Locations/-3,-1.png", -3, -1);
			world.AddLocation("River source", "River source", "pack://application:,,,/Engine;component/Images/Locations/-2,-1.png", -2, -1);
			world.AddLocation("Way to village", "Way to village", "pack://application:,,,/Engine;component/Images/Locations/-1,-1.png", -1, -1);
			world.AddLocation("Temple", "Temple region", "pack://application:,,,/Engine;component/Images/Locations/0,-1.png", 0, -1);
			world.AddLocation("Roads", "Roads", "pack://application:,,,/Engine;component/Images/Locations/1,-1.png", 1, -1);
			world.AddLocation("Village", "Village", "pack://application:,,,/Engine;component/Images/Locations/2,-1.png", 2, -1);
			world.AddLocation("River", "Main river", "pack://application:,,,/Engine;component/Images/Locations/3,-1.png", 3, -1);
			world.AddLocation("Forest's ravine", "Ravine", "pack://application:,,,/Engine;component/Images/Locations/4,-1.png", 4, -1);

			return world;
		}
	}
}
