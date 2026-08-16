using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ReputationTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class Rank_ : IGeneratorObject
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
		public int Id;

		[ProtoMember(2)]
		public Rank_ Rank;

		[ProtoMember(3)]
		public int Reputation;

		[ProtoMember(4)]
		public double DiamondBonus;

		[ProtoMember(5)]
		public double ReputationBonus;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ReputationTemplate, new()
		{
			return null;
		}

		public static ReputationTemplate[] Load()
		{
			return null;
		}
	}
}
