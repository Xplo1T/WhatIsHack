using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMemory;
using System.Threading.Tasks;
using LoLAPIInfo;
using System.Windows;

namespace LoLAPI
{
		public class Player
		{

		public string getName()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var name = x.ReadString(LeagueAdressesOffsets.PlayerObject.Name, 16);
			x.Disconnect();
			return name;
		}
		private int getUserGold()
			{
				MemoryManager x = new MemoryManager();
				x.Attach("League of Legends");
				var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
				var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.Gold.Offset);
				var gold = x.ReadInteger(GoldAdress.ToInt32());
				x.Disconnect();
				return gold;
			}
			private int getCurrentMana()
			{
				MemoryManager x = new MemoryManager();
				x.Attach("League of Legends");
				var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Stats.Offset);
				var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Stats.currentMana.Offset);
				var gold = x.ReadInteger(GoldAdress.ToInt32());
				x.Disconnect();
				return gold;
			}
			private int getMaximumMana()
			{
				MemoryManager x = new MemoryManager();
				x.Attach("League of Legends");
				var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Stats.Offset);
				var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Stats.MaxMana.Offset);
				var gold = x.ReadInteger(GoldAdress.ToInt32());
				x.Disconnect();
				return gold;
			}
			private int getMaximumHealth()
			{
				MemoryManager x = new MemoryManager();
				x.Attach("League of Legends");
				var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Stats.Offset);
				var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Stats.MaxHealth.Offset);
				var gold = x.ReadInteger(GoldAdress.ToInt32());
				x.Disconnect();
				return gold;
			}
			private int getCurrentHealth()
			{
				MemoryManager x = new MemoryManager();
				x.Attach("League of Legends");
				var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Stats.Offset);
				var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Stats.currentHealth.Offset);
				var gold = x.ReadInteger(GoldAdress.ToInt32());
				x.Disconnect();
				return gold;
			}
			private int getAD()
			{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.AD.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
			}
		private int getAP()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.AP.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
		}
		private int getAS()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.AS.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
		}
		private int getArmor()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.Armor.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
		}
		private int getMagicResist()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.MagicResist.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
		}
		private int getMoveSpeed()
		{
			MemoryManager x = new MemoryManager();
			x.Attach("League of Legends");
			var GoldLv1Adress = (IntPtr)(x.ReadInteger(LeagueAdressesOffsets.PlayerObject.BaseAdress) + LeagueAdressesOffsets.PlayerObject.Attributes.Offset);
			var GoldAdress = (IntPtr)(x.ReadInteger(GoldLv1Adress.ToInt32()) + LeagueAdressesOffsets.PlayerObject.Attributes.MoveSpeed.Offset);
			var gold = x.ReadFloat(GoldAdress.ToInt32());
			x.Disconnect();
			return Convert.ToInt32(Math.Round(gold));
		}
		public int CurrentMana{
				get {
					return getCurrentMana();
				}
			}

			public int MaximumMana
			{
				get
				{
					return getMaximumMana();
				}
			}
			public int AD
			{
				get
				{
					return getAD();
				}
			}
		public int MaximumHealth
			{
				get
				{
					return getMaximumHealth();
				}
			}
			public int CurrentHealth
			{
				get
				{
					return getCurrentHealth();
				}
			}
			public int Gold
			{
				get
				{
					return getUserGold();
				}
			}
		public int AS
		{
			get
			{
				return getAS();
			}
		}
		public int AP
		{
			get
			{
				return getAP();
			}
		}
		public int Armor
		{
			get
			{
				return getArmor();
			}
		}
		public int MagicResist
		{
			get
			{
				return getMagicResist();
			}
		}
		public int MovementSpeed
		{
			get
			{
				return getMoveSpeed();
			}
		}
	}
		
	
}
