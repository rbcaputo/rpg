using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.General
{
	public class ItemModel
	{
		public string Name { get; set; } = string.Empty;
		public string Category { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public bool IsQuestItem { get; set; }

		public int BuyPrice { get; set; }
		public int SellPrice { get; set; }

		public ItemModel(string name, string category, string description, bool isQuestItem = false, int buyPrice = 0, int sellPrice = 0)
		{
			Name = name;
			Category = category;
			Description = description;
			IsQuestItem = isQuestItem;
			BuyPrice = buyPrice;
			SellPrice = sellPrice;
		}
	}
}
