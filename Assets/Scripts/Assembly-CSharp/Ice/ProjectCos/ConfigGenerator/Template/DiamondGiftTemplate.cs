using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DiamondGiftTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Item : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public int VipCondition;

		[ProtoMember(4)]
		public int InitialPrice;

		[ProtoMember(5)]
		public string Desc;

		[ProtoMember(6)]
		public Item[] Items;

		[ProtoMember(7)]
		public int NowPrice;

		[ProtoMember(8)]
		public int New;

		[ProtoMember(9)]
		public int TotallyLimitation;

		[ProtoMember(10)]
		public int Hot;

		[ProtoMember(11)]
		public int DailyLimitation;

		[ProtoMember(12)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DiamondGiftTemplate, new()
		{
			return null;
		}

		public static DiamondGiftTemplate[] Load()
		{
			return null;
		}
	}
}
