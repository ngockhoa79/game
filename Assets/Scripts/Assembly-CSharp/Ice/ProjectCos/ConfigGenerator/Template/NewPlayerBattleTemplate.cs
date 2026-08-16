using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class NewPlayerBattleTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Timing;

		[ProtoMember(2)]
		public int Order;

		[ProtoMember(3)]
		public int CharacterId;

		[ProtoMember(4)]
		public int Position;

		[ProtoMember(5)]
		public int Action;

		[ProtoMember(6)]
		public int MoveType;

		[ProtoMember(7)]
		public string Dialog;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : NewPlayerBattleTemplate, new()
		{
			return null;
		}

		public static NewPlayerBattleTemplate[] Load()
		{
			return null;
		}
	}
}
