using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class MonsterTextTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string DialogWin;

		[ProtoMember(4)]
		public string DialogSkill;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : MonsterTextTemplate, new()
		{
			return null;
		}

		public static MonsterTextTemplate[] Load()
		{
			return null;
		}
	}
}
