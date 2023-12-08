using Engine.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Quests
{
	public class QuestModel
	{
		// General
		public int ID { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		// Delivery
		public List<ItemQuantity> Delivery { get; set; } = new();

		// Rewards
		public int Experience { get; set; }
		public int Gold { get; set; }
		public List<ItemQuantity> Items { get; set; } = new();

		public QuestModel(int id, string name, string description, List<ItemQuantity> delivery, int experience, int gold, List<ItemQuantity> items)
		{
			ID = id;
			Name = name;
			Description = description;
			Delivery = delivery;
			Experience = experience;
			Gold = gold;
			Items = items;
		}
	}
}
