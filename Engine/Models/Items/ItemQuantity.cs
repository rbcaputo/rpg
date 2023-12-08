using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Engine.Models.Items
{
	public class ItemQuantity
	{
		public int ItemID { get; set; }
		public int Quantity { get; set; }

		public ItemQuantity(int itemID, int quantity)
		{
			ItemID = itemID;
			Quantity = quantity;
		}
	}
}
