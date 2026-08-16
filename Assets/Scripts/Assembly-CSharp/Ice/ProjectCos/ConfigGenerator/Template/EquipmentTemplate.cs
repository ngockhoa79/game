using ProtoBuf;

namespace Ice.ProjectCos.ConfigGenerator.Template
{
	[ProtoContract]
	public class EquipmentTemplate : IGeneratorObject
	{
		[ProtoContract]
		public class MainProperty_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Base;

			[ProtoMember(3)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class MainValueRange_ : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Min;

			[ProtoMember(2)]
			public int Max;

			public virtual void Init()
			{
			}
		}

		[ProtoContract]
		public class DropLevel : IGeneratorObject
		{
			[ProtoMember(1)]
			public int Type;

			[ProtoMember(2)]
			public int Param1;

			[ProtoMember(3)]
			public int Param2;

			public virtual void Init()
			{
			}
		}

		[ProtoMember(1)]
		public int Id;

		[ProtoMember(2)]
		public string Icon;

		[ProtoMember(3)]
		public int RarityType;

		[ProtoMember(4)]
		public int Type;

		[ProtoMember(5)]
		public int ChipId;

		[ProtoMember(6)]
		public int ChipNumber;

		[ProtoMember(7)]
		public MainProperty_ MainProperty;

		[ProtoMember(8)]
		public MainValueRange_ MainValueRange;

		[ProtoMember(9)]
		public int SoldPrice;

		[ProtoMember(10)]
		public DropLevel[] DropLevels;

		public virtual void Init()
		{
		}

		public static T[] Load<T>() where T : EquipmentTemplate, new()
		{
			return null;
		}

		public static EquipmentTemplate[] Load()
		{
			return null;
		}
	}
}
