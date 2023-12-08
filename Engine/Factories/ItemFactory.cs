using Engine.Models.Items;
using Engine.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
	public static class ItemFactory
	{
		private static readonly List<ItemModel> _items = new();

		static ItemFactory()
		{
			_items.Add(new WeaponModel(1001, "Test sword", "sword", "A test sword", 1, 2, 2, 1));
			_items.Add(new WeaponModel(1002, "Test axe", "axe", "A test axe", 2, 3, 2, 1));
			_items.Add(new ItemModel(901, "Test item", "loot", "A test item", 0.5, 0, 1));
		}

		public static ItemModel GenerateItem(int id)
		{
			ItemModel? item = _items.Find(itm => itm.ID == id);

			if (item == null) return null;
			else return item.CloneItem();
		}
	}
}
