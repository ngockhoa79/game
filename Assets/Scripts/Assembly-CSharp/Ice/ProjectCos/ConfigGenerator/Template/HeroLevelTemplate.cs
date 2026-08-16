using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class HeroLevelTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int CardLevel;

		[ProtoMember(2)]
		public int Exp_1;

		[ProtoMember(3)]
		public int Exp_2;

		[ProtoMember(4)]
		public int Exp_3;

		[ProtoMember(5)]
		public int Exp_4;

		[ProtoMember(6)]
		public int Exp_5;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : HeroLevelTemplate, new()
		{
			return null;
		}

		public static HeroLevelTemplate[] Load()
		{
			return null;
		}
	}
}
