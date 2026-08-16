using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class RmbShopTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int Type;

		[ProtoMember(3)]
		public string ProductName;

		[ProtoMember(4)]
		public int[] Channels;

		[ProtoMember(5)]
		public string Name;

		[ProtoMember(6)]
		public int Amount;

		[ProtoMember(7)]
		public int Extra;

		[ProtoMember(8)]
		public int Extra1;

		[ProtoMember(9)]
		public double Rmb;

		[ProtoMember(10)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : RmbShopTemplate, new()
		{
			return null;
		}

		public static RmbShopTemplate[] Load()
		{
			return null;
		}
	}
}
