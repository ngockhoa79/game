using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildShopPreviewTemplate : IGeneratorObject
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

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int ShopId;

		[ProtoMember(3)]
		public Goods_ Goods;

		[ProtoMember(4)]
		public string Name;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildShopPreviewTemplate, new()
		{
			return null;
		}

		public static GuildShopPreviewTemplate[] Load()
		{
			return null;
		}
	}
}
