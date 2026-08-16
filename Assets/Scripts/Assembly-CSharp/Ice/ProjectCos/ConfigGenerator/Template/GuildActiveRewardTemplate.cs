using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildActiveRewardTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class RewardItem1 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem2 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem3 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem4 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem5 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem6 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem7 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem8 : IGeneratorObject
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

		[ProtoContract]
		public class RewardItem9 : IGeneratorObject
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
		public int ActiveValue;

		[ProtoMember(3)]
		public RewardItem1[] RewardItem1s;

		[ProtoMember(4)]
		public RewardItem2[] RewardItem2s;

		[ProtoMember(5)]
		public RewardItem3[] RewardItem3s;

		[ProtoMember(6)]
		public RewardItem4[] RewardItem4s;

		[ProtoMember(7)]
		public RewardItem5[] RewardItem5s;

		[ProtoMember(8)]
		public RewardItem6[] RewardItem6s;

		[ProtoMember(9)]
		public RewardItem7[] RewardItem7s;

		[ProtoMember(10)]
		public RewardItem8[] RewardItem8s;

		[ProtoMember(11)]
		public RewardItem9[] RewardItem9s;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildActiveRewardTemplate, new()
		{
			return null;
		}

		public static GuildActiveRewardTemplate[] Load()
		{
			return null;
		}
	}
}
