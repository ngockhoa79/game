using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class PriceTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Energy_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Euplicate_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class ActivityDuplicate_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class ShoprRefresh_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Money_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			[ProtoMember(3)]
			public int Gold;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Trial_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Challenge_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossPersonBuyCount_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class CrossPersonCleanCD_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class RobSkill_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class GuildRedPacket_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class RedPacket_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Times;

		[ProtoMember(2)]
		public Energy_ Energy;

		[ProtoMember(3)]
		public Euplicate_ Euplicate;

		[ProtoMember(4)]
		public ActivityDuplicate_ ActivityDuplicate;

		[ProtoMember(5)]
		public ShoprRefresh_ ShoprRefresh;

		[ProtoMember(6)]
		public Money_ Money;

		[ProtoMember(7)]
		public Trial_ Trial;

		[ProtoMember(8)]
		public Challenge_ Challenge;

		[ProtoMember(9)]
		public CrossPersonBuyCount_ CrossPersonBuyCount;

		[ProtoMember(10)]
		public CrossPersonCleanCD_ CrossPersonCleanCD;

		[ProtoMember(11)]
		public RobSkill_ RobSkill;

		[ProtoMember(12)]
		public GuildRedPacket_ GuildRedPacket;

		[ProtoMember(13)]
		public RedPacket_ RedPacket;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : PriceTemplate, new()
		{
			return null;
		}

		public static PriceTemplate[] Load()
		{
			return null;
		}
	}
}
