using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class OnlineRewardTemplate : IGeneratorObject
	{
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
		public int ID;

		[ProtoMember(2)]
		public int Time;

		[ProtoMember(3)]
		public RewardItem[] RewardItems;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : OnlineRewardTemplate, new()
		{
			return null;
		}

		public static OnlineRewardTemplate[] Load()
		{
			return null;
		}
	}
}
