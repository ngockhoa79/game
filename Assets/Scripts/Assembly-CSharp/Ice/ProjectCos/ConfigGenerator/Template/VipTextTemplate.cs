using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class VipTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public string Text;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : VipTextTemplate, new()
		{
			return null;
		}

		public static VipTextTemplate[] Load()
		{
			return null;
		}
	}
}
