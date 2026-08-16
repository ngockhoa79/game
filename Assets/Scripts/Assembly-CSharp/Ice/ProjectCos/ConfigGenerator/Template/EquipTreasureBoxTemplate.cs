using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EquipTreasureBoxTemplate : IGeneratorObject
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
		public int GoldEquipBox;

		[ProtoMember(6)]
		public int SilverEquipBox;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EquipTreasureBoxTemplate, new()
		{
			return null;
		}

		public static EquipTreasureBoxTemplate[] Load()
		{
			return null;
		}
	}
}
