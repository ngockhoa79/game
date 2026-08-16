using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class VIPLevelTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Bonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class JumpLevel : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int Money;

		[ProtoMember(3)]
		public Bonus[] Bonuss;

		[ProtoMember(4)]
		public int BuyEnergy;

		[ProtoMember(5)]
		public int BuyPVE;

		[ProtoMember(6)]
		public int BuyActivity;

		[ProtoMember(7)]
		public int BuyTrail;

		[ProtoMember(8)]
		public JumpLevel[] JumpLevels;

		[ProtoMember(9)]
		public int DropGroup;

		[ProtoMember(10)]
		public int RedPack;

		[ProtoMember(11)]
		public int GuildRedPack;

		[ProtoMember(12)]
		public int BuyPVP;

		[ProtoMember(13)]
		public int BuyRobSkill;

		[ProtoMember(14)]
		public int BuyCrossPerson;

		[ProtoMember(15)]
		public int CleanCrossPersonCD;

		[ProtoMember(16)]
		public int FreeSweepCount;

		[ProtoMember(17)]
		public int ShopTriggerRate;

		[ProtoMember(18)]
		public int ShopRefresh;

		[ProtoMember(19)]
		public int BuyGold;

		[ProtoMember(20)]
		public int BuyTreasureBox;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : VIPLevelTemplate, new()
		{
			return null;
		}

		public static VIPLevelTemplate[] Load()
		{
			return null;
		}
	}
}
