using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.Quests
{
	public class QuestStatus
	{
		public QuestModel Quest { get; set; }
		public bool IsCompleted { get; set; }

		public QuestStatus(QuestModel quest, bool isCompleted = false)
		{
			Quest = quest;
			IsCompleted = isCompleted;
		}
	}
}
