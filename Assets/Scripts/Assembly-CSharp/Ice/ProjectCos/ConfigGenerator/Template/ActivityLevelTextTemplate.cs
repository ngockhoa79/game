using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ActivityLevelTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Discribe;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ActivityLevelTextTemplate, new()
		{
			return null;
		}

		public static ActivityLevelTextTemplate[] Load()
		{
			return null;
		}
	}
}
