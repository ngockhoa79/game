using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildActiveBuffTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Bonuses : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Num;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int BuffId;

		[ProtoMember(2)]
		public string Icon;

		[ProtoMember(3)]
		public int UnlockLevel;

		[ProtoMember(4)]
		public int MaxLevel;

		[ProtoMember(5)]
		public Bonuses[] Bonusess;

		[ProtoMember(6)]
		public int CostContribution;

		[ProtoMember(7)]
		public int CostGold;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildActiveBuffTemplate, new()
		{
			return null;
		}

		public static GuildActiveBuffTemplate[] Load()
		{
			return null;
		}
	}
}
