using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class TreasureBoxTemplate : IGeneratorObject
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
		public int WoodBox;

		[ProtoMember(6)]
		public int IronBox;

		[ProtoMember(7)]
		public int GoldBox;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : TreasureBoxTemplate, new()
		{
			return null;
		}

		public static TreasureBoxTemplate[] Load()
		{
			return null;
		}
	}
}
