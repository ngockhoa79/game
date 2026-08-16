using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class MisteryShopMiddleTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Goods_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class NumberRange : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Num;

			[ProtoMember(2)]
			public int Weight;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public Goods_ Goods;

		[ProtoMember(3)]
		public int Weight;

		[ProtoMember(4)]
		public int PayType;

		[ProtoMember(5)]
		public double Price;

		[ProtoMember(6)]
		public NumberRange[] NumberRanges;

		[ProtoMember(7)]
		public int[] Positions;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : MisteryShopMiddleTemplate, new()
		{
			return null;
		}

		public static MisteryShopMiddleTemplate[] Load()
		{
			return null;
		}
	}
}
