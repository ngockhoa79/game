using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossGuildSeasonRankBonusTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Range_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class RankBonus : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Id;

			[ProtoMember(3)]
			public int Count;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int ID;

		[ProtoMember(2)]
		public Range_ Range;

		[ProtoMember(3)]
		public RankBonus[] RankBonuss;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossGuildSeasonRankBonusTemplate, new()
		{
			return null;
		}

		public static CrossGuildSeasonRankBonusTemplate[] Load()
		{
			return null;
		}
	}
}
