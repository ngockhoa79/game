using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ItemTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Description;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ItemTextTemplate, new()
		{
			return null;
		}

		public static ItemTextTemplate[] Load()
		{
			return null;
		}
	}
}
