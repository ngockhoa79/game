using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class GuildLevelTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Level;

		[ProtoMember(2)]
		public int LevelExp;

		[ProtoMember(3)]
		public int MaxCount;

		[ProtoMember(4)]
		public int VicePresidentCount;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : GuildLevelTemplate, new()
		{
			return null;
		}

		public static GuildLevelTemplate[] Load()
		{
			return null;
		}
	}
}
