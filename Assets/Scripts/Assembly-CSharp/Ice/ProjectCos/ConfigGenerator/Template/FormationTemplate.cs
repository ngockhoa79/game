using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class FormationTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public int ColunmNumber;

		[ProtoMember(3)]
		public int[] LeaderPositions;

		[ProtoMember(4)]
		public int[] BossPositions;

		[ProtoMember(5)]
		public int WarningPosition;

		[ProtoMember(6)]
		public int[] EnterTypes;

		[ProtoMember(7)]
		public int[] EnemyPositions;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : FormationTemplate, new()
		{
			return null;
		}

		public static FormationTemplate[] Load()
		{
			return null;
		}
	}
}
