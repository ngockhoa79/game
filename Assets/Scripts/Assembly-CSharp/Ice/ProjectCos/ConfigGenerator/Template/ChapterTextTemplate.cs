using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ChapterTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string ChapterName;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ChapterTextTemplate, new()
		{
			return null;
		}

		public static ChapterTextTemplate[] Load()
		{
			return null;
		}
	}
}
