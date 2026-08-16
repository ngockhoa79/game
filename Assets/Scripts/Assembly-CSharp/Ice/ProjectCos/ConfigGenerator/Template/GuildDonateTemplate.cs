using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildDonateTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Cost_ : IGeneratorObject
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
		public class RewardItem : IGeneratorObject
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
		public Cost_ Cost;

		[ProtoMember(3)]
		public RewardItem[] RewardItems;

		[ProtoMember(4)]
		public int ActiveValue;

		[ProtoMember(5)]
		public int Contribution;

		[ProtoMember(6)]
		public int GuildDonateVip;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildDonateTemplate, new()
		{
			return null;
		}

		public static GuildDonateTemplate[] Load()
		{
			return null;
		}
	}
}
