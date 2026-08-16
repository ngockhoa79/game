using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EscortLevelTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int Exp;

		[ProtoMember(3)]
		public double AdditionalGold;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EscortLevelTemplate, new()
		{
			return null;
		}

		public static EscortLevelTemplate[] Load()
		{
			return null;
		}
	}
}
