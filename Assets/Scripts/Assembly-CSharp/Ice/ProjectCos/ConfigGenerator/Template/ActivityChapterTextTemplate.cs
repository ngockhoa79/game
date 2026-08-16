using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ActivityChapterTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Discibe;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ActivityChapterTextTemplate, new()
		{
			return null;
		}

		public static ActivityChapterTextTemplate[] Load()
		{
			return null;
		}
	}
}
