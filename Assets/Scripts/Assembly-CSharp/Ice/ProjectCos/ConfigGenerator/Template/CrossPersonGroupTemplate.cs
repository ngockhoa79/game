using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossPersonGroupTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class BaseGroupBonus : IGeneratorObject
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
		public int GroupID;

		[ProtoMember(2)]
		public int Score;

		[ProtoMember(3)]
		public int Drop;

		[ProtoMember(4)]
		public int Show;

		[ProtoMember(5)]
		public BaseGroupBonus[] BaseGroupBonuss;

		[ProtoMember(6)]
		public double DiamondBonusRate;

		[ProtoMember(7)]
		public double CrossCoinBonusRate;

		[ProtoMember(8)]
		public int LastSeasonBonus;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossPersonGroupTemplate, new()
		{
			return null;
		}

		public static CrossPersonGroupTemplate[] Load()
		{
			return null;
		}
	}
}
