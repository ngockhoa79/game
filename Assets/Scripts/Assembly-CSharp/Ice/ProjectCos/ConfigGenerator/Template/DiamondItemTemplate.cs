using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DiamondItemTemplate : IGeneratorObject
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
		public Item[] Items;

		[ProtoMember(3)]
		public int VipCondition;

		[ProtoMember(4)]
		public string Name;

		[ProtoMember(5)]
		public int InitialPrice;

		[ProtoMember(6)]
		public int NowPrice;

		[ProtoMember(7)]
		public int New;

		[ProtoMember(8)]
		public int TotallyLimitation;

		[ProtoMember(9)]
		public int Hot;

		[ProtoMember(10)]
		public int DailyLimitation;

		[ProtoMember(11)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DiamondItemTemplate, new()
		{
			return null;
		}

		public static DiamondItemTemplate[] Load()
		{
			return null;
		}
	}
}
