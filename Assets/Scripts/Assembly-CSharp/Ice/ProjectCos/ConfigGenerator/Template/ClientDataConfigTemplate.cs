using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ClientDataConfigTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int HeroWalkSpeed;

		[ProtoMember(2)]
		public int HeroRunSpeed;

		[ProtoMember(3)]
		public double SupportHelpEmoteTime;

		[ProtoMember(4)]
		public int BattleSkipVIPLevel;

		[ProtoMember(5)]
		public int BattleSkipTeamLevel;

		[ProtoMember(6)]
		public int BattleSkipTime;

		public virtual void Init()
		{
		}

		public static T Load<T>() where T : ClientDataConfigTemplate, new()
		{
			return null;
		}

		public static ClientDataConfigTemplate Load()
		{
			return null;
		}
	}
}
