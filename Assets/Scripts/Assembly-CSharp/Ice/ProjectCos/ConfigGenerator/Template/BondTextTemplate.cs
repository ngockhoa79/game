using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class BondTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string Text;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : BondTextTemplate, new()
		{
			return null;
		}

		public static BondTextTemplate[] Load()
		{
			return null;
		}
	}
}
