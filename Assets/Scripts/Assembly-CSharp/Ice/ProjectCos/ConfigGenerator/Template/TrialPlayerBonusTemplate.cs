using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TrialPlayerBonusTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Bonus : IGeneratorObject
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
		public int Level;

		[ProtoMember(2)]
		public Bonus[] Bonuss;

		[ProtoMember(3)]
		public int Coin;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TrialPlayerBonusTemplate, new()
		{
			return null;
		}

		public static TrialPlayerBonusTemplate[] Load()
		{
			return null;
		}
	}
}
