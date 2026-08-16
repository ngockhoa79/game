using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildIconTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int GuildIconId;

		[ProtoMember(2)]
		public string Icon;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildIconTemplate, new()
		{
			return null;
		}

		public static GuildIconTemplate[] Load()
		{
			return null;
		}
	}
}
