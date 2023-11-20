using Engine.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models.General
{
	public class PlayerModel : NotificationClass
	{
		// Backing variables
		private int _level;
		private int _experience;
		private int _gold;

		private int _strength;
		private int _dexterity;
		private int _constitution;
		private int _intelligence;
		private int _wisdom;
		private int _charisma;

		private int _maxLife;
		private int _currentLife;
		private int _maxMana;
		private int _currentMana;

		// General
		public string Name { get; set; } = string.Empty;
		public string Race { get; set; } = string.Empty;
		public string Class { get; set; } = string.Empty;
		public int Level
		{
			get { return _level; }
			set
			{
				_level = value;
				OnPropertyChanged(nameof(Level));
			}
		}
		public int Experience
		{
			get { return _experience; }
			set
			{
				_experience = value;
				OnPropertyChanged(nameof(Experience));
			}
		}
		public int Gold
		{
			get { return _gold; }
			set
			{
				_gold = value;
				OnPropertyChanged(nameof(Gold));
			}
		}

		// Attributes
		public int Strength
		{
			get { return _strength; }
			set
			{
				_strength = value;
				OnPropertyChanged(nameof(Strength));
			}
		}
		public int Dexterity
		{
			get { return _dexterity; }
			set
			{
				_dexterity = value;
				OnPropertyChanged(nameof(Dexterity));
			}
		}
		public int Constitution
		{
			get { return _constitution; }
			set
			{
				_constitution = value;
				OnPropertyChanged(nameof(Constitution));
			}
		}
		public int Intelligence
		{
			get { return _intelligence; }
			set
			{
				_intelligence = value;
				OnPropertyChanged(nameof(Intelligence));
			}
		}
		public int Wisdom
		{
			get { return _wisdom; }
			set
			{
				_wisdom = value;
				OnPropertyChanged(nameof(Wisdom));
			}
		}
		public int Charisma
		{
			get { return _charisma; }
			set
			{
				_charisma = value;
				OnPropertyChanged(nameof(Charisma));
			}
		}

		// Pool
		public int MaxLife
		{
			get { return _maxLife; }
			set
			{
				_maxLife = value;
				OnPropertyChanged(nameof(MaxLife));
			}
		}
		public int CurrentLife
		{
			get { return _currentLife; }
			set
			{
				_currentLife = value;
				OnPropertyChanged(nameof(CurrentLife));
			}
		}
		public int MaxMana
		{
			get { return _maxMana; }
			set
			{
				_maxMana = value;
				OnPropertyChanged(nameof(MaxMana));
			}
		}
		public int CurrentMana
		{
			get { return _currentMana; }
			set
			{
				_currentMana = value;
				OnPropertyChanged(nameof(CurrentMana));
			}
		}
	}
}
