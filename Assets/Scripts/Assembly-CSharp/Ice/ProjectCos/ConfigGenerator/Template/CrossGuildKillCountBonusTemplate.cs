using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossGuildKillCountBonusTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class KillCountRange_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int ID;

		[ProtoMember(2)]
		public KillCountRange_ KillCountRange;

		[ProtoMember(3)]
		public double BraveCoinRate;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossGuildKillCountBonusTemplate, new()
		{
			return null;
		}

		public static CrossGuildKillCountBonusTemplate[] Load()
		{
			return null;
		}
	}
}
