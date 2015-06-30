using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPIInfo
{
	static class LeagueAdressesOffsets
	{

		public static class PlayerObject
		{
			public static int Name = 0x131F3A0;
			public static int BaseAdress = 0x0131E850;
			
				/*
				get
				{
					SimpleMemory.MemoryManager x = new SimpleMemory.MemoryManager();
					x.Attach("League of Legends");
					var adress = x.FindPattern(new byte[] { 0x89, 0x47, 0x4C, 0xC6, 0x07, 0x00, 0xF3, 0x0F, 0x10, 0x45, 0xE0, 0x0F, 0x2E, 0x47, 0x54 }, "xxxxxxxxxxxxxxx", 0x8);
					return adress.ToInt32();
				}*/
			
			public static class Attributes
			{
				public static int Offset = 0xFC;
				public static class Gold
				{
					public static int Offset = 0xC;
				}
				public static class MoveSpeed
				{
					public static int Offset = 0x30;
				}
				public static class AD
				{
					public static int Offset = 0x24;
				}
				public static class AP
				{
					public static int Offset = 0x1C;
				}
				public static class MagicResist
				{
					public static int Offset = 0x2C;
				}
				public static class AS
				{
					public static int Offset = 0x28;
				}
				public static class Armor
				{
					public static int Offset = 0x20;
				}
			}
			public static class Stats
			{
				public static int Offset = 0x100;
				
				public static class currentHealth
				{
					public static int Offset = 0x3C;
				}
				public static class MaxHealth
				{
					public static int Offset = 0x40;
				}
				public static class currentMana
				{
					public static int Offset = 0x4C;
				}
				public static class MaxMana
				{
					public static int Offset = 0x50;
				}
			}
		}

	}
}
