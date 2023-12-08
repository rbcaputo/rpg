using Engine.Models.Items;
using Engine.Models.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
	internal static class QuestFactory
	{
		private static readonly List<QuestModel> _quests = new();

		static QuestFactory()
		{
			List<ItemQuantity> delivery = new();
			List<ItemQuantity> items = new();

			delivery.Add(new ItemQuantity(901, 1));
			items.Add(new ItemQuantity(1001, 1));

			_quests.Add(new QuestModel(001, "Test quest", "A test quest", delivery, 10, 5, items));
		}

		internal static QuestModel? GetQuestByID(int id) { return _quests.Find(qst => qst.ID == id); }
	}
}
