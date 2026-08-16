using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TrialGuardBonusTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class GuardBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class BossBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Rank;

		[ProtoMember(2)]
		public GuardBonus[] GuardBonuss;

		[ProtoMember(3)]
		public BossBonus[] BossBonuss;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TrialGuardBonusTemplate, new()
		{
			return null;
		}

		public static TrialGuardBonusTemplate[] Load()
		{
			return null;
		}
	}
}
