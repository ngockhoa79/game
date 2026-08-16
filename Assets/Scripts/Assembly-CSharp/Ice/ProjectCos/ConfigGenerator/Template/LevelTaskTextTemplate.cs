using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class LevelTaskTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Discribe;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : LevelTaskTextTemplate, new()
		{
			return null;
		}

		public static LevelTaskTextTemplate[] Load()
		{
			return null;
		}
	}
}
