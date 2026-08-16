using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildPartyTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class ItemBonus_ : IGeneratorObject
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
		public int Id;

		[ProtoMember(2)]
		public int Money;

		[ProtoMember(3)]
		public int Min;

		[ProtoMember(4)]
		public int Max;

		[ProtoMember(5)]
		public int PresidentContribution;

		[ProtoMember(6)]
		public ItemBonus_ ItemBonus;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildPartyTemplate, new()
		{
			return null;
		}

		public static GuildPartyTemplate[] Load()
		{
			return null;
		}
	}
}
