using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildTaskTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string TaskName;

		[ProtoMember(3)]
		public string RewardDesc;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildTaskTextTemplate, new()
		{
			return null;
		}

		public static GuildTaskTextTemplate[] Load()
		{
			return null;
		}
	}
}
