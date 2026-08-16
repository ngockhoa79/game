using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class OpenServerSaleItemTemplate : IGeneratorObject
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
		public int InitialPrice;

		[ProtoMember(5)]
		public int NowPrice;

		[ProtoMember(6)]
		public int New;

		[ProtoMember(7)]
		public int TotallyLimitation;

		[ProtoMember(8)]
		public int Hot;

		[ProtoMember(9)]
		public int DailyLimitation;

		[ProtoMember(10)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : OpenServerSaleItemTemplate, new()
		{
			return null;
		}

		public static OpenServerSaleItemTemplate[] Load()
		{
			return null;
		}
	}
}
