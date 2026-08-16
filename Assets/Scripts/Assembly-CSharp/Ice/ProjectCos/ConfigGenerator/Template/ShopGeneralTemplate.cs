using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ShopGeneralTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Condition_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int GoodsNum;

		[ProtoMember(3)]
		public Condition_ Condition;

		[ProtoMember(4)]
		public string[] RefreshTimes;

		[ProtoMember(5)]
		public string BackGround;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ShopGeneralTemplate, new()
		{
			return null;
		}

		public static ShopGeneralTemplate[] Load()
		{
			return null;
		}
	}
}
