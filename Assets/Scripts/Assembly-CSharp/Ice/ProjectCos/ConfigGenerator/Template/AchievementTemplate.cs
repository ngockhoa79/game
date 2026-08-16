using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class AchievementTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class AchievementInfo_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			[ProtoMember(4)]
			public int Param3;

			[ProtoMember(5)]
			public int Param4;

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
		public int PreAchievementId;

		[ProtoMember(3)]
		public int ShowProgress;

		[ProtoMember(4)]
		public AchievementInfo_ AchievementInfo;

		[ProtoMember(5)]
		public RewardItem[] RewardItems;

		[ProtoMember(6)]
		public string TaskIcon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : AchievementTemplate, new()
		{
			return null;
		}

		public static AchievementTemplate[] Load()
		{
			return null;
		}
	}
}
