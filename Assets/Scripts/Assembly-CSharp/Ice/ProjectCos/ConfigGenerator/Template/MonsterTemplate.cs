using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class MonsterTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string Name;

		[ProtoMember(3)]
		public int HeroId;

		[ProtoMember(4)]
		public double Rate;

		[ProtoMember(5)]
		public int TalentSkill;

		[ProtoMember(6)]
		public int[] AdditionSkills;

		[ProtoMember(7)]
		public int[] FeatureSkills;

		[ProtoMember(8)]
		public double HPRate;

		[ProtoMember(9)]
		public double AttackRate;

		[ProtoMember(10)]
		public double DefenseRate;

		[ProtoMember(11)]
		public double SpriteRate;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : MonsterTemplate, new()
		{
			return null;
		}

		public static MonsterTemplate[] Load()
		{
			return null;
		}
	}
}
