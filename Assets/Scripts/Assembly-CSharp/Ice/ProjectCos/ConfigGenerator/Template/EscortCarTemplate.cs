using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EscortCarTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class CompleteBonus : IGeneratorObject
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
		public int Id;

		[ProtoMember(2)]
		public int Price;

		[ProtoMember(3)]
		public int Weight;

		[ProtoMember(4)]
		public int InitialRate;

		[ProtoMember(5)]
		public int RatePromote;

		[ProtoMember(6)]
		public double ProductPlus;

		[ProtoMember(7)]
		public double RobRate;

		[ProtoMember(8)]
		public double DefenceBonus;

		[ProtoMember(9)]
		public int PromoteNumber;

		[ProtoMember(10)]
		public CompleteBonus[] CompleteBonuss;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EscortCarTemplate, new()
		{
			return null;
		}

		public static EscortCarTemplate[] Load()
		{
			return null;
		}
	}
}
