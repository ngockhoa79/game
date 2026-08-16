using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class AnnouncementTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string Text;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : AnnouncementTextTemplate, new()
		{
			return null;
		}

		public static AnnouncementTextTemplate[] Load()
		{
			return null;
		}
	}
}
