using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class LevelTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string LevelName;

		[ProtoMember(3)]
		public string Discribe;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : LevelTextTemplate, new()
		{
			return null;
		}

		public static LevelTextTemplate[] Load()
		{
			return null;
		}
	}
}
