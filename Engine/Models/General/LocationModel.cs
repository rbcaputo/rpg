using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models.Quests;

namespace Engine.Models.General
{
	public class LocationModel
	{
		// General
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;


		// Coordinates
		public int XCoordinate { get; set; }
		public int YCoordinate { get; set; }

		// Quests
		public List<QuestModel> Quests { get; set; } = new();
	}
}
