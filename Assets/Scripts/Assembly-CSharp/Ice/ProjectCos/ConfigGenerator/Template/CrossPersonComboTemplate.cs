using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CrossPersonComboTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int ContinueCount;

		[ProtoMember(2)]
		public int Bonus;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CrossPersonComboTemplate, new()
		{
			return null;
		}

		public static CrossPersonComboTemplate[] Load()
		{
			return null;
		}
	}
}
