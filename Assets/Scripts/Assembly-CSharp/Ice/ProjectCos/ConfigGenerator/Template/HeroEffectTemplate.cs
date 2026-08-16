using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class HeroEffectTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class BoneEffectPair : IGeneratorObject
		{
			[ProtoMember(1)]
			public string BoneName;

			[ProtoMember(2)]
			public string EffectName;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int HeroId;

		[ProtoMember(2)]
		public BoneEffectPair[] BoneEffectPairs;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : HeroEffectTemplate, new()
		{
			return null;
		}

		public static HeroEffectTemplate[] Load()
		{
			return null;
		}
	}
}
