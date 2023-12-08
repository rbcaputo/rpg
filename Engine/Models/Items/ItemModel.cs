using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Items
{
	public class ItemModel
	{
		// General
		public int ID { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Category { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public double Weight { get; set; }

		// Prices
		public int BuyPrice { get; set; }
		public int SellPrice { get; set; }

		// Quest related
		public bool IsQuestItem { get; set; }

		public ItemModel(int id, string name, string category, string description, double weight, int buyPrice = 0, int sellPrice = 0, bool isQuestItem = false)
		{
			ID = id;
			Name = name;
			Category = category;
			Description = description;
			Weight = weight;
			BuyPrice = buyPrice;
			SellPrice = sellPrice;
			IsQuestItem = isQuestItem;
		}

		public ItemModel CloneItem() { return new ItemModel(ID, Name, Category, Description, Weight, BuyPrice, SellPrice, IsQuestItem); }
	}
}
