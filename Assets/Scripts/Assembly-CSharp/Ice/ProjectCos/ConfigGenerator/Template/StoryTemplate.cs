using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class StoryTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int PVEId;

		[ProtoMember(2)]
		public int Timing;

		[ProtoMember(3)]
		public int EnterColumn;

		[ProtoMember(4)]
		public int Order;

		[ProtoMember(5)]
		public int CharacterId;

		[ProtoMember(6)]
		public int NpcEm;

		[ProtoMember(7)]
		public int Position;

		[ProtoMember(8)]
		public int Action;

		[ProtoMember(9)]
		public int EnterPos;

		[ProtoMember(10)]
		public int HasPlayerName;

		[ProtoMember(11)]
		public string Dialog;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : StoryTemplate, new()
		{
			return null;
		}

		public static StoryTemplate[] Load()
		{
			return null;
		}
	}
}
