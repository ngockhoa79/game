using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class DialogTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int HeroId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Image;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : DialogTemplate, new()
		{
			return null;
		}

		public static DialogTemplate[] Load()
		{
			return null;
		}
	}
}
