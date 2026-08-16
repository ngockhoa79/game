using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class NewPlayerStoryTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Animationblockid;

		[ProtoMember(2)]
		public int CharacterId;

		[ProtoMember(3)]
		public int Position;

		[ProtoMember(4)]
		public int Action;

		[ProtoMember(5)]
		public int Flag;

		[ProtoMember(6)]
		public string Dialog;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : NewPlayerStoryTemplate, new()
		{
			return null;
		}

		public static NewPlayerStoryTemplate[] Load()
		{
			return null;
		}
	}
}
