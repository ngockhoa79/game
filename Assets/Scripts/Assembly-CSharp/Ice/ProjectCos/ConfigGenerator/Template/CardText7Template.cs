using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class CardText7Template : IGeneratorObject
	{
		[ProtoMember(1)]
		public int TextId;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public string Description;

		[ProtoMember(4)]
		public string DialogWin;

		[ProtoMember(5)]
		public string DialogSkill;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : CardText7Template, new()
		{
			return null;
		}

		public static CardText7Template[] Load()
		{
			return null;
		}
	}
}
