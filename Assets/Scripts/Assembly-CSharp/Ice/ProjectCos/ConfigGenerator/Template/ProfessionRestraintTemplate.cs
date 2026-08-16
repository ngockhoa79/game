using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class ProfessionRestraintTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int AttackerProfession;

		[ProtoMember(2)]
		public int DefenderProfession;

		[ProtoMember(3)]
		public int Damage;

		[ProtoMember(4)]
		public int AttackAttacker;

		[ProtoMember(5)]
		public int AttackDefender;

		[ProtoMember(6)]
		public int CritAttacker;

		[ProtoMember(7)]
		public int AntiCritDefender;

		[ProtoMember(8)]
		public int AntiMissAttacker;

		[ProtoMember(9)]
		public int MissDefender;

		[ProtoMember(10)]
		public int AntiBlockAttacker;

		[ProtoMember(11)]
		public int BlockDefender;

		[ProtoMember(12)]
		public int BatterAttacker;

		[ProtoMember(13)]
		public int AntiBatterDefender;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : ProfessionRestraintTemplate, new()
		{
			return null;
		}

		public static ProfessionRestraintTemplate[] Load()
		{
			return null;
		}
	}
}
