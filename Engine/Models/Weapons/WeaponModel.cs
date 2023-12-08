using Engine.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Weapons
{
    public class WeaponModel : ItemModel
	{
		public int MinDamage { get; set; }
		public int MaxDamage { get; set; }

		public WeaponModel(int id, string name, string category, string description, double weight, int minDamage, int maxDamage, int buyPrice = 0, int sellPrice = 0, bool isQuestItem = false) : base(id, name, category, description, weight, buyPrice, sellPrice, isQuestItem)
		{
			MinDamage = minDamage;
			MaxDamage = maxDamage;
		}

		public WeaponModel CloneWeapon() { return new WeaponModel(ID, Name, Category, Description, Weight, MinDamage, MaxDamage, BuyPrice, SellPrice, IsQuestItem); }
	}
}
