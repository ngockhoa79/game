using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildActiveBuffTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int BuffId;

		[ProtoMember(2)]
		public string BuffName;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildActiveBuffTextTemplate, new()
		{
			return null;
		}

		public static GuildActiveBuffTextTemplate[] Load()
		{
			return null;
		}
	}
}
