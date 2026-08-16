using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossPersonComboPushTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class ComboDiffer_ : IGeneratorObject
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
		public ComboDiffer_ ComboDiffer;

		[ProtoMember(3)]
		public int Weigh;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossPersonComboPushTemplate, new()
		{
			return null;
		}

		public static CrossPersonComboPushTemplate[] Load()
		{
			return null;
		}
	}
}
