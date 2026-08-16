using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EscortRangeTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class RangeOrder : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Level;

			[ProtoMember(2)]
			public int Order;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public RangeOrder[] RangeOrders;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EscortRangeTemplate, new()
		{
			return null;
		}

		public static EscortRangeTemplate[] Load()
		{
			return null;
		}
	}
}
