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
			public static int BaseAdress = 0x024EE850;
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
