using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class HeroTreasureBoxTemplate : IGeneratorObject
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
		public int HeavySwordBox;

		[ProtoMember(6)]
		public int LightSwordBox;

		[ProtoMember(7)]
		public int FighterBox;

		[ProtoMember(8)]
		public int MageBox;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : HeroTreasureBoxTemplate, new()
		{
			return null;
		}

		public static HeroTreasureBoxTemplate[] Load()
		{
			return null;
		}
	}
}
