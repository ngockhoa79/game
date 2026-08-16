using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public string TextId;

		[ProtoMember(2)]
		public string Text;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TextTemplate, new()
		{
			return null;
		}

		public static TextTemplate[] Load()
		{
			return null;
		}
	}
}
