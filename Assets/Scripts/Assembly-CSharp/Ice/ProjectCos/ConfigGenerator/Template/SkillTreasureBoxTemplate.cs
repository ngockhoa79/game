using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class SkillTreasureBoxTemplate : IGeneratorObject
	{
		[ProtoMember(1)]
		public int DropId;

		[ProtoMember(2)]
		public int DropItem;

		[ProtoMember(3)]
		public int DropNumber;

		[ProtoMember(4)]
		public int DropType;

		[ProtoMember(5)]
		public int GoldSkillBox;

		[ProtoMember(6)]
		public int SilverSkillBox;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : SkillTreasureBoxTemplate, new()
		{
			return null;
		}

		public static SkillTreasureBoxTemplate[] Load()
		{
			return null;
		}
	}
}
