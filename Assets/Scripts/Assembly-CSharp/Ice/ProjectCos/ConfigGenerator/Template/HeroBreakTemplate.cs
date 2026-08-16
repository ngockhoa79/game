using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class HeroBreakTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class MaterialCard : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Id;

			[ProtoMember(2)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class Material : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Id;

			[ProtoMember(2)]
			public int Number;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int OriginalHeroId;

		[ProtoMember(2)]
		public int BreakPrice;

		[ProtoMember(3)]
		public int TargetHeroId;

		[ProtoMember(4)]
		public MaterialCard[] MaterialCards;

		[ProtoMember(5)]
		public Material[] Materials;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : HeroBreakTemplate, new()
		{
			return null;
		}

		public static HeroBreakTemplate[] Load()
		{
			return null;
		}
	}
}
